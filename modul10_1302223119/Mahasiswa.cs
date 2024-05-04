namespace modul10_1302223119
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string nim {  get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            Name = name;
            this.nim = nim;
            Course = course;
            Year = year;
        }
    }
}
