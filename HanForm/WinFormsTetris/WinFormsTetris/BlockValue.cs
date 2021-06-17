﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace WinFormsTetris
{
    static class BlockValue //테트리스 떨어지는 블럭, [형태,회전,4,4]
    {
        static public readonly Brush[] bcolors = new Brush[7]
        {
            Brushes.Purple,
            Brushes.SteelBlue,
            Brushes.Orange,
            Brushes.DarkRed,
            Brushes.Pink,
            Brushes.Gray,
            Brushes.Wheat
        };


        static public readonly int[,,,] bvals = new int[7, 4, 4, 4]
        {
            {
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 1, 1, 1, 1 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 1, 1, 1, 1 },
                    { 0, 0, 0, 0 }
                }
            },
            {
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 0, 0 }
                }
            },
            {
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 1, 1, 1 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 1 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 1 },
                    { 0, 1, 0, 0 }
                }
            },
            {
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 1 },
                    { 0, 0, 0, 1 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 1, 1, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 1, 1, 1 },
                    { 0, 0, 0, 0 }
                }
            },
            {
                {
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 1 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 1, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 1, 0 },
                    { 0, 1, 1, 1 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 }
                }
            },
            {
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 1, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 1 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 1, 0 }
                }
            },
            {
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 0, 1 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 1, 1, 0 },
                    { 0, 0, 0, 0 }
                },
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 1, 1 },
                    { 0, 0, 0, 1 }
                }
            }
        };
    }
}