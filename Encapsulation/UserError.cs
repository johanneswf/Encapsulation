using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field. This fired an error!";
    }

    public class TextInputError : UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numeric only field. This fired an error!";
    }

    public class EmptyInputError : UserError
    {
        public override string UEMessage() => "You tried to input an empty value in a field that needed a value. This fired an error!";
    }

    public class FloatInputError : UserError
    {
        public override string UEMessage() => "You tried to use a floating point value in an integer only field. This fired an error!";
    }

    public class NonBoolInputError : UserError
    {
        public override string UEMessage() => "You tried to input a non-boolean value in a boolean only field. This fired an error!";
    }
}
