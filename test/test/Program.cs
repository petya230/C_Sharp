using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CodeRetreat2013
{
    public class LifeGame
    {
        private HashSet<Tuple<int, int>> alive;

        private LifeGame(params Tuple<int, int>[] alive)
        {
            this.alive = new HashSet<Tuple<int, int>>(alive);
        }

        private LifeGame MakeStep()
        {
            alive = new HashSet<Tuple<int, int>>(
                alive.Concat(alive.SelectMany(Neighbours)).Where(ShouldBeAlive));
            return this;
        }

        private bool ShouldBeAlive(Tuple<int, int> xy)
        {
            return WillAliveWithThatNeighboursCount(xy,
                Neighbours(xy).Where(neighb => !xy.Equals(neighb)).Count(alive.Contains));
        }

        private bool WillAliveWithThatNeighboursCount(Tuple<int, int> xy, int aliveCount)
        {
            return aliveCount == 3 || aliveCount == 2 && alive.Contains(xy);
        }

        private IEnumerable<Tuple<int, int>> Neighbours(Tuple<int, int> xy)
        {
            return Enumerable.Range(xy.Item1 - 1, 3).SelectMany(
                x => Enumerable.Range(xy.Item2 - 1, 3).Select(y => Tuple.Create(x, y))
                    .Where(c => !c.Equals(xy)));
        }

        public string ToString(int minX, int width, int minY, int height)
        {
            return string.Join(
                Environment.NewLine,
                Enumerable.Range(minY, height).Select(y => LineToString(y, minX, width)));
        }

        private static readonly IDictionary<bool, char> cellSymbols =
            new Dictionary<bool, char> { { false, ' ' }, { true, '#' } };

        public string LineToString(int y, int minX, int width)
        {
            return new string(
                Enumerable.Range(minX, width).Select(x => Tuple.Create(x, y))
                    .Select(cell => cellSymbols[alive.Contains(cell)]).ToArray());
        }

        private static readonly IDictionary<bool, Action<LifeGame>> nextStep =
            new Dictionary<bool, Action<LifeGame>>
            { { true, g => { } }, { false, VisualizeGame } };

        public static void VisualizeGame(LifeGame game)
        {
            Console.Clear();
            Console.WriteLine(game.MakeStep().ToString(-10, 20, -10, 20));
            WaitAndContinue(nextStep[Console.KeyAvailable], game);

        }

        private static void WaitAndContinue(Action<LifeGame> continuation, LifeGame game)
        {
            Thread.Sleep(100);
            continuation(game);
        }

        public static void Main()
        {
            Console.CursorVisible = false;
            VisualizeGame(new LifeGame(Tuple.Create(1, 0), Tuple.Create(2, 0),
                Tuple.Create(3, 0), Tuple.Create(1, 1), Tuple.Create(2, 2), Tuple.Create(2, 3), Tuple.Create(2, 6)));
        }
    }
}