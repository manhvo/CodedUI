/*
$safeitemrootname$
Description: {TODO: PUT TEST CASE DESCRIPTION HERE}
Preconditions:
	{TODO: PUT TEST CASE PRECONDITION HERE}
Rev History
$time$	$username$	Init
Copyright Jeppesen Sanderson Inc $year$.  All rights reserved
*/
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FDProWindowAutoTest.TestScripts;
using FDProWindowAutoTest.Classes;
using FDProWindowAutoTest.Utils;
using System.Reflection;

namespace $rootnamespace$
{
    /// <summary>
    /// {TODO: PUT TEST SUITE SUMMARY HERE}
    /// </summary>
    /// <seealso cref="FDProWindowAutoTest.TestScripts.TestScriptBase" />
    [CodedUITest(CodedUITestType.WindowsStore)]
    [TestSuite(Name = "$safeitemrootname$",
               Summary = "{TODO: PUT TEST SUITE SUMMARY HERE}")]
    class $safeitemrootname$ : TestScriptBase
	{
        #region Class level variables
        #endregion

        #region Setup Precondition
        /// <summary>
        /// Setups the precondition.
        /// </summary>
        protected override void SetupPrecondition()
        {
			// This method is optional
			
            // If you want to add addtional actions after the app starts,
			// add the new source code in this method.
			
			// You can remove this method if you don't want to add addtional
			// actions
        }
        #endregion

        #region Test cases
        /// <summary>
        /// {TODO: PUT TEST CASE SUMMARY HERE}
        /// </summary>
        [TestMethod]
        [TestCase(Precondition = "{TODO: PUT TEST CASE PRECONDITION HERE}",
                          ReqIDs = new string[] { "{TODO: PUT REQUIREMENTS ID HERE}" },
                          ReqDescriptions = new string[] { "{TODO: PUT REQUIREMENT DESCRIPTIONS HERE}" },
                          Description = "{TODO: PUT TEST CASE DESCRIPTION HERE}",
                          ManualTestCases = "{TODO: PUT MANUAL TEST CASE ID HERE}",
                          ExcludedManualTestSteps = new string[] { "{TODO: PUT STEPS YOU CAN'T AUTOMATE}" })]
        [TestCategory("{TODO: PUT FUNCTION_GROUP HERE}")]
        public void Test_AAAAAAAAAAAAAAA()//TODO: CHANGE THE TEST METHOD NAME}
        {

            TestCaseLog(MethodBase.GetCurrentMethod());

            // --------------------------------------------------------
            HelpTestLog.TcNote("Step 1");
        }
    #endregion
    }
}
