﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModMan.Entities
{
    /// <summary>
    /// Describes the commonly supported logical switch functions.
    /// </summary>
    public enum LogicalSwitchFunction
    {
        /// <summary>
        /// Indicates that the switch has not been configured and is disabled.
        /// </summary>
        /// <remarks>
        /// Often represented as '---'.
        /// </remarks>
        None,

        /// <summary>
        /// Check if the value of A (a selectable source) is equal to X (a chosen value).
        /// </summary>
        /// <remarks>
        /// Often represented as 'a=x'.
        /// </remarks>
        ValueEqual,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is approximately equal to X (a chosen value).
        /// </summary>
        /// <remarks>
        /// <para>
        /// Often represented as 'a~x'.
        /// </para>
        /// <para>
        /// "Approximately" generally means + or –  0.9 from the desired value. 
        /// </para>
        /// </remarks>
        ValueApproximately,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is greater than X (a chosen value).
        /// </summary>
        /// <remarks>
        /// Often represented as 'a>x'.
        /// </remarks>
        ValueGreater,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is less than X (a chosen value).
        /// </summary>
        /// <remarks>
        /// Often represented as 'a&lt;x'.
        /// </remarks>
        ValueLess,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is greater than X (a chosen value).
        /// </summary>
        /// <remarks>
        /// Often represented as '|a|>x'.
        /// </remarks>
        ValueGreaterAbsolute,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is less than X (a chosen value).
        /// </summary>
        /// <remarks>
        /// Often represented as '|a|&lt;x'.
        /// </remarks>
        ValueLessAbsolute,

        /// <summary>
        /// Checks that BOTH switches V1 AND V2 are true.
        /// </summary>
        /// <remarks>
        /// Often represented as 'AND'.
        /// </remarks>
        And,

        /// <summary>
        /// Checks if either switch V1 or V2 are true.
        /// </summary>
        /// <remarks>
        /// Often represented as 'OR'.
        /// </remarks>
        Or,

        /// <summary>
        /// Checks if either but NOT BOTH V1 and V2 are true.
        /// </summary>
        /// <remarks>
        /// Often represented as 'XOR'.
        /// </remarks>
        Xor,

        /// <summary>
        /// A momentary switch which can be activated by another switch depending on the length of time that switch 
        /// is "true".
        /// </summary>
        /// <remarks>
        /// Often represented as 'Edge'.
        /// </remarks>
        Edge,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is equal to B (a different selectable source).
        /// </summary>
        /// <remarks>
        /// Often represented as 'a=b'.
        /// </remarks>
        SourceEqual,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is greater than B (a different selectable source).
        /// </summary>
        /// <remarks>
        /// Often represented as 'a>b'.
        /// </remarks>
        SourceGreater,

        /// <summary>
        /// Checks to see if the value of A (a selectable source) is less than B (a different selectable source).
        /// </summary>
        /// <remarks>
        /// Often represented as 'a&lt;b'.
        /// </remarks>
        SourceLess,

        /// <summary>
        /// Checks to see if the Delta (change in value) of A (a selectable source) is greater than or equal to 
        /// specified value X.
        /// </summary>
        /// <remarks>
        /// Often represented as 'd>=x'.
        /// </remarks>
        DiffGreater,

        /// <summary>
        /// Checks to see if the absolute Delta (change in value) of A (a selectable source) is greater than or equal to 
        /// specified value X.
        /// </summary>
        /// <remarks>
        /// Often represented as '|d|>=x'.
        /// </remarks>
        DiffeGreaterAbsolute,

        /// <summary>
        /// Causes the switch to turn ON or OFF at specified intervals.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Often represented as 'Timer'.
        /// </para>
        /// <para>
        /// V1: Is the on time.
        /// V2: the off time.
        /// </para>
        /// </remarks>
        Timer,

        /// <summary>
        /// Causes the switch to act like a toggle.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Often represented as 'Timer'.
        /// </para>
        /// <para>
        /// V1: Is the switch to turn On.
        /// V2: Is the switch to turn Off.
        /// </para>
        /// </remarks>
        Sticky,
    }
    
    /// <summary>
    /// The interface for a logical switch.
    /// </summary>
    /// <remarks>
    /// Most radios follow the <see href="http://open-txu.org/home/continuing-education/logical-switch-functions/">
    /// standard defined by OpenTX</see>. EdgeTX defines data types for these functions in 
    /// <see href="https://github.com/EdgeTX/edgetx/blob/main/companion/src/firmwares/edgetx/yaml_logicalswitchdata.cpp">
    /// yaml_logicalswitchdata.cpp</see>.
    /// </remarks>
    public interface ILogicalSwitch
    {
    }
}