﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCasesPasswordSamlet
{
    public class PasswordChecks
    {
        public static string PasswordOutput = @"C:\Users\allgaw\Documents\C#\TreCases\TreCasesPasswordSamlet\TreCasesPasswordSamlet\Passwords.txt";
        public static bool PasswordCreate()
        {
            string PasswordInput;
            Console.WriteLine("Indtast kodeorden");
            PasswordInput = Console.ReadLine();
            if (PasswordChecks.MinimumLength(PasswordInput) && PasswordChecks.UpperAndLower(PasswordInput) && PasswordChecks.IncludesNumbers(PasswordInput) &&
                PasswordChecks.NoNumbersAtStartOrEnd(PasswordInput) == true && PasswordChecks.DoesNotContainSpaces(PasswordInput) == true)
            {
                Console.WriteLine("Den indtastede kodeord er gyldig, du må fortsætte.");
                StreamWriter sw = new StreamWriter(PasswordOutput, true, Encoding.ASCII);
                sw.WriteLine(PasswordInput);
                sw.Close();
                return (true);
            }
            else
            {
                Console.Write("Den indtastede kodeord er ugyldig, prøv igen.");
                return (false);
            }
        }
        public static bool MinimumLength(string PasswordInput)
        {
            if (PasswordInput.Length > 11)
            {
                return (true);
            }
            return (false);
        }
        public static bool UpperAndLower(string PasswordInput)
        {
            if (PasswordInput.Any(char.IsUpper) && PasswordInput.Any(char.IsLower))
            {
                return (true);
            }
            return (false);
        }
        public static bool IncludesNumbers(string PasswordInput)
        {
            if (PasswordInput.Any(d => char.IsDigit(d)))
            {
                return (true);
            }
            return (false);
        }
        public static bool NoNumbersAtStartOrEnd(string PasswordInput)
        {
            if (char.IsDigit(PasswordInput[0])) //&& char.IsDigit(PasswordInput[PasswordInput.Length])  // fungerer ikke helt.
            {
                return (false);
            }
            return (true);
        }
        public static bool DoesNotContainSpaces(string PasswordInput)
        {
            if (PasswordInput.Contains(" "))
            {
                return (false);
            }
            return (true);
        }
    }
}