﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppz_fkmm.BackSource
{
    class Program
    {
        private readonly ApiHttpHelper httpStream;

        Program()
        {
            httpStream.InitializeClient();
        }
    }
}
