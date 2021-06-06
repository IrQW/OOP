namespace ConsoleApplication1.Properties.transport.road
{
    public class BactrianCamel : RoadTransport
    {
        public BactrianCamel() : base(10, 30, (count) => (count == 1) ? 5 : 8)
        {
        }
    }
}