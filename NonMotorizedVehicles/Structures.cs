using Enumerations;

namespace Structures
{
    public struct Tricycle
    {
        private bool isMoving;
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }

        public bool Moving()
        {
            return this.isMoving;
        }

        public bool Driving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
    }
}
