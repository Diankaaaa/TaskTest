using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest.Model
{
    public interface IFileService
    {
        List<Factorial> OpenFactorial(string fileName);
        void SaveFactorial(string fileName);
    }
}
