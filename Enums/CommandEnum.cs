using System.ComponentModel;

namespace practices_basics.Enums
{

        // Enums are the class which contains a set of named constant int value fields
        // use enum when the value will not be changed
        // enum can be explicitly convert to int type

        enum Commands
        {
            [Description("Z")]
            Initialize,//0

            GeneralInitialize,
            LightUp,
            ShowAddress,

            ShowAmount

        }

}