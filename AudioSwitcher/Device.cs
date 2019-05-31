namespace AudioSwitcher
{
    class Device
    {
        int id;
        string name;

        public Device()
        {
            id = 0;
            name = "";
        }
        public Device(int inputID, string inputDevice)
        {
            this.Id = inputID;
            this.Name = inputDevice;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
