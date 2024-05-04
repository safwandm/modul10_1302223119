using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace modul10_1302223119.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mahasiswaList = new()
        {
            new Mahasiswa("Yoga Fikri Rizkulloh", "1302220101", ["Basis Data"], 1984),
            new Mahasiswa("Kyntar Barra Langit Lubis", "1302220113", ["Basis Data"], 1984),
            new Mahasiswa("Haidar Abdul Halim", "1302220152", ["Basis Data"], 1984)
        };

        [HttpGet]
        public IEnumerable GetMahasiswaList()
        {
            return mahasiswaList;
        }

        [HttpPost]
        public string PostMahasiswa([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return $"{mhs.Name} telah ditambahkan ke list";
        }

        [HttpGet("{id}")]
        public Mahasiswa GetMahasiswa(int id)
        {
            return mahasiswaList[id];
        }

        [HttpDelete("{id}")]
        public string DeleteMahasiswa(int id) {
            string nama = mahasiswaList[id].Name;
            mahasiswaList.RemoveAt(id);
            return $"{nama} telah dihapus dari list";
        }
    }
}
