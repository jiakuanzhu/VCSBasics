namespace VCSBasics
{
    public class MyCircle
    {
        public int Radius { get; set; };
        public CenteredCoordinate CenteredCoordinate { get; set; };
    }

    class CenteredCoordinate
    {
        private int x;
        private int y;
    }
}