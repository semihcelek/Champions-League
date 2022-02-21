using System.Collections.Generic;

namespace SemihCelek.Champions_League.Models.DataAccess
{
    public interface IDataAccess
    {
        List<string> ReadLines();
    }
}