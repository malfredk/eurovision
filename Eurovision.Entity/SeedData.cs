using Eurovision.Entity.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurovision.Entity;

public static class SeedData
{
    public static PlayerEntity player1 = new()
    {
        Id = 1,
        UserName = "malfred"
    };
}
