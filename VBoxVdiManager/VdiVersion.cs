namespace VBoxVdiManager
{
    public struct VdiVersion
    {
        public VdiVersion(short major, short minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public short Major { get; }
        public short Minor { get; }

        public override string ToString()
        {
            return $"{this.Major}.{this.Minor}";
        }
    }
}
