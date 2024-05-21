using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Animals
{
    internal interface IIdentifiable
    {
        Guid Id { get; }
    }
}
