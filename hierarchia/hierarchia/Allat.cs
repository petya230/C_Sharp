namespace hierarchia
{
    internal abstract class Allat
    {
        string nev;

        public Allat(string nev)
        {
            this.nev = nev;
        }

        public virtual void AdatokFelvesz()
        {
        }
        public virtual void AdatokKiolvas()
        {

        }
        public string GetNev() => nev;
    }
}