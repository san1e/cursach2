using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Animals
{
    public interface IBreedable
    {
        List<string> Breeds { get; } // Получение списка пород
    }
}
