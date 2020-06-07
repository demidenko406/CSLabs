using System;
using System.Runtime.InteropServices;

namespace Lab4_1
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        [DllImport("User32.dll")]
        public static extern int GetKeyState(int i);

        static void Main(string[] args)
        {
            bool isShiftPressed = false;

            while (true)
            {
                for (int i = 8; i < 223; i++)
                {
                    if (GetAsyncKeyState(i) == 32769)
                    {
                        if (GetKeyState(16) == 65408 || GetKeyState(16) == 65409)   //Shift
                        {
                            switch (i)
                            {
                                case 48: Console.Write(") "); break;
                                case 49: Console.Write("! "); break;
                                case 50: Console.Write("@ "); break;
                                case 51: Console.Write("# "); break;
                                case 52: Console.Write("$ "); break;
                                case 53: Console.Write("% "); break;
                                case 54: Console.Write("^ "); break;
                                case 55: Console.Write("& "); break;
                                case 56: Console.Write("* "); break;
                                case 57: Console.Write("( "); break;
                                case 160:
                                    if (!isShiftPressed)
                                    {
                                        Console.Write("leftShift ");
                                        isShiftPressed = true;
                                    }
                                    break;
                                case 161:
                                    if (!isShiftPressed)
                                    {
                                        Console.Write("rightShift ");
                                        isShiftPressed = true;
                                    }
                                    break;
                                case 186: Console.Write(": "); break;
                                case 187: Console.Write("+ "); break;
                                case 188: Console.Write("< "); break;
                                case 189: Console.Write("_ "); break;
                                case 190: Console.Write("> "); break;
                                case 191: Console.Write("? "); break;
                                case 192: Console.Write("~ "); break;
                                case 219: Console.Write("{ "); break;
                                case 220: Console.Write("| "); break;
                                case 221: Console.Write("} "); break;
                                case 222: Console.Write('"' + " "); break;
                                default:
                                    if ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z'))
                                    {
                                        if (Console.CapsLock)
                                        {
                                            Console.Write((char)(i + 32) + " ");
                                        }
                                        else
                                        {
                                            Console.Write((char)i + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            isShiftPressed = false;

                            switch (i)
                            {
                                case 8: Console.Write("Backspace "); break;
                                case 9: Console.Write("Tab "); break;
                                case 13: Console.Write("Enter "); break;
                                case 20: Console.Write("CapsLock "); break;
                                case 22: Console.Write("' "); break;
                                case 27: Console.Write("Escape "); break;
                                case 32: Console.Write("Space "); break;
                                case 37: Console.Write("pgLeft "); break;
                                case 38: Console.Write("pgUp "); break;
                                case 39: Console.Write("pgRight "); break;
                                case 40: Console.Write("pgDown "); break;
                                case 91: Console.Write("Win "); break;
                                case 162: Console.Write("leftCtrl "); break;
                                case 163: Console.Write("rightCtrl "); break;
                                case 164: Console.Write("leftAlt "); break;
                                case 165: Console.Write("rightAlt "); break;
                                case 186: Console.Write("; "); break;
                                case 187: Console.Write("= "); break;
                                case 188: Console.Write(", "); break;
                                case 189: Console.Write("- "); break;
                                case 190: Console.Write(". "); break;
                                case 191: Console.Write("/ "); break;
                                case 192: Console.Write("` "); break;
                                case 219: Console.Write("[ "); break;
                                case 220: Console.Write(@"\ "); break;
                                case 221: Console.Write("] "); break;
                                case 222: Console.Write("' "); break;
                                default:
                                    if ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z') || (i >= '0' && i <= '9'))
                                    {
                                        if (Console.CapsLock || (i >= '0' && i <= '9'))
                                        {
                                            Console.Write((char)i + " ");
                                        }
                                        else
                                        {
                                            Console.Write((char)(i + 32) + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}