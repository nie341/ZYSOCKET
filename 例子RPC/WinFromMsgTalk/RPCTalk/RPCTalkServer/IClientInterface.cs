﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCTalkServer
{
    interface WinClient
    {
        void MessageShow(string msg);

        void UpdateUserList();
    }
}
