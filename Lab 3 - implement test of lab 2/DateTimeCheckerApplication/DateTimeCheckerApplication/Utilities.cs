using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCheckerApplication {
    public class Utilities {
        public static byte DaysInMonth(ushort Year, byte Month) {
            switch (Month) {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (Year % 400 == 0) {
                        return 29;
                    } else {
                        if (Year % 100 == 0) {
                            return 28;
                        } else {
                            if (Year % 4 == 0) {
                                return 29;
                            } else {
                                return 28;
                            }
                        }
                    }
                default:
                    return 0;
            }
        }
        public static bool IsValidDate(short Year, byte Month, byte Day) {
                if (Day >= 1) {
                    if (Day <= DaysInMonth((ushort)Year, Month)) {
                        return true;
                    } else {
                        return false;
                    }
                } else {
                    return false;
                }
        }
    }
}
