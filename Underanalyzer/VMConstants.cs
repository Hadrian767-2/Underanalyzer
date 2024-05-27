﻿namespace Underanalyzer;

/// <summary>
/// Contains constant values used by the GameMaker VM.
/// </summary>
internal static class VMConstants
{
    // Function names used for try..catch..finally statements
    public const string TryHookFunction = "@@try_hook@@";
    public const string TryUnhookFunction = "@@try_unhook@@";
    public const string FinishCatchFunction = "@@finish_catch@@";
    public const string FinishFinallyFunction = "@@finish_finally@@";

    // Function names for creating methods/structs
    public const string MethodFunction = "method";
    public const string NullObjectFunction = "@@NullObject@@";
    public const string NewObjectFunction = "@@NewGMLObject@@";

    // Function name used to copy static information from an inherited constructor functioon in GML
    public const string CopyStaticFunction = "@@CopyStatic@@";

    // Instance type helpers used in GMLv2
    public const string SelfFunction = "@@This@@";
    public const string OtherFunction = "@@Other@@";
    public const string GlobalFunction = "@@Global@@";
    public const string GetInstanceFunction = "@@GetInstance@@";

    // The size limit of arrays in GMLv1 (old GML). Used for 2D array accesses in the VM.
    public const int OldArrayLimit = 32000;

    // Used to create array literals in GML
    public const string NewArrayFunction = "@@NewGMLArray@@";

    // Used to store return values before cleaning up stack
    public const string TempReturnVariable = "$$$$temp$$$$";

    // Function name used to throw an object/exception
    public const string ThrowFunction = "@@throw@@";

    // Variable names used by compiler to rewrite try/catch/finally
    public const string TryBreakVariable = "__yy_breakEx";
    public const string TryContinueVariable = "__yy_continueEx";
    public const string TryCopyVariable = "copyVar";
}
