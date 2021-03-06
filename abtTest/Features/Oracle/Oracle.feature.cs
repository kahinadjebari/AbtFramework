﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace abtTest.Features.Oracle
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Oracle", Description="\t\tIn order to Ensure the Estability of\r\n\t\tOur ERP\r\n\t\tI Want To Perform a Functioa" +
        "l Test", SourceFile="Features\\Oracle\\Oracle.feature", SourceLine=0)]
    public partial class OracleFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Oracle.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Oracle", "\t\tIn order to Ensure the Estability of\r\n\t\tOur ERP\r\n\t\tI Want To Perform a Functioa" +
                    "l Test", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt US Employee Direct Access", new string[] {
                "Oracle"}, SourceLine=7)]
        public virtual void AbtUSEmployeeDirectAccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt US Employee Direct Access", new string[] {
                        "Oracle"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("i login as \"oumsalems\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("click the \"Abt US Employee Direct Access\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("browse to \"Employee Self Service Actions Awaiting Your Attention\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("click the \"Abt US Employee Direct Access\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("browse to \"Personal Information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("click the \"Abt US Employee Direct Access\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And("browse to \"Extra Information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("click the \"Abt US Employee Direct Access\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("browse to \"Benefits\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("click the \"Abt US Employee Direct Access\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("browse to \"Voluntary Disclosure of Disability\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("click the \"Abt US Employee Direct Access\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And("browse to \"Voluntary Disclosure of Veterans Status\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt US Projects Inquiry Access", new string[] {
                "Oracle"}, SourceLine=25)]
        public virtual void AbtUSProjectsInquiryAccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt US Projects Inquiry Access", new string[] {
                        "Oracle"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("i login as \"PCTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("click the \"Abt US Projects Inquiry\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("iProcurement Request", new string[] {
                "Oracle"}, SourceLine=33)]
        public virtual void IProcurementRequest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("iProcurement Request", new string[] {
                        "Oracle"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("i login as \"oumsalems\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("click the \"Abt US iProcurement Requester\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.Then("click iProcurement request and then Non-Catalog Req", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("fill the request form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("Checkout the cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.And("Fill Requisition Information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("Then assign \"Elguera, Jorge L\" after requisition and submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Then assign \"Samuel, Noel N\" after requisition and submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("Submit after approvers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.When("i hit submit the request is done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Requisition approval", new string[] {
                "Oracle"}, SourceLine=48)]
        public virtual void RequisitionApproval()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Requisition approval", new string[] {
                        "Oracle"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("i login as \"ElgueraJ\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("click the \"Abt US iProcurement Inquiry\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("complete the order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Timecard vacations Request", new string[] {
                "Oracle"}, SourceLine=56)]
        public virtual void TimecardVacationsRequest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Timecard vacations Request", new string[] {
                        "Oracle"});
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("i login as \"oumsalems\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("click the \"Abt US Timecards\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.And("go to time entry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("fill the TimeCard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("close complete the timeCard request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Approve Timecard", new string[] {
                "Oracle"}, SourceLine=66)]
        public virtual void ApproveTimecard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Approve Timecard", new string[] {
                        "Oracle"});
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("i login as \"ElgueraJ\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("click the \"Abt US iProcurement Inquiry\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.And("complete the order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Creation and approval of PO", new string[] {
                "Oracle"}, SourceLine=75)]
        public virtual void CreationAndApprovalOfPO()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creation and approval of PO", new string[] {
                        "Oracle"});
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
    testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("i login as \"KruckM\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("click the \"Abt US PO Buyer\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.And("browse to Requisitions under Buyer Work Center", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("select a requisition to add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.And("click Add and Create", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Purchasing Request", new string[] {
                "Oracle"}, SourceLine=87)]
        public virtual void PurchasingRequest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Purchasing Request", new string[] {
                        "Oracle"});
#line 88
this.ScenarioSetup(scenarioInfo);
#line 89
    testRunner.Given("I have Open IE Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("i login as \"KruckM\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("click the \"Abt US PO Buyer\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("browse to Requisitions under Requisitions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("I fill the Oracle Forms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt Employee Roster", new string[] {
                "Oracle"}, SourceLine=97)]
        public virtual void AbtEmployeeRoster()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt Employee Roster", new string[] {
                        "Oracle"});
#line 98
this.ScenarioSetup(scenarioInfo);
#line 99
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 100
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.Then("click the \"Abt Employee Roster\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HR Desktop Integration", new string[] {
                "Oracle"}, SourceLine=104)]
        public virtual void AbtHRDesktopIntegration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HR Desktop Integration", new string[] {
                        "Oracle"});
#line 105
this.ScenarioSetup(scenarioInfo);
#line 106
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then("click the \"Abt HR Desktop Integration\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HR Operations Self Service", new string[] {
                "Oracle"}, SourceLine=113)]
        public virtual void AbtHROperationsSelfService()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HR Operations Self Service", new string[] {
                        "Oracle"});
#line 114
this.ScenarioSetup(scenarioInfo);
#line 115
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 116
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.Then("click the \"Abt HR Operations Self Service\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HR System Administrator", new string[] {
                "Oracle"}, SourceLine=122)]
        public virtual void AbtHRSystemAdministrator()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HR System Administrator", new string[] {
                        "Oracle"});
#line 123
this.ScenarioSetup(scenarioInfo);
#line 124
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 125
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.Then("click the \"Abt HR System Administrator\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HR User", new string[] {
                "Oracle"}, SourceLine=131)]
        public virtual void AbtHRUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HR User", new string[] {
                        "Oracle"});
#line 132
this.ScenarioSetup(scenarioInfo);
#line 133
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.Then("click the \"Abt HR User\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HRMS Benefits User", new string[] {
                "Oracle"}, SourceLine=140)]
        public virtual void AbtHRMSBenefitsUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HRMS Benefits User", new string[] {
                        "Oracle"});
#line 141
this.ScenarioSetup(scenarioInfo);
#line 142
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 143
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("click the \"Abt HRMS Benefits User\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HRMS Superuser", new string[] {
                "Oracle"}, SourceLine=148)]
        public virtual void AbtHRMSSuperuser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HRMS Superuser", new string[] {
                        "Oracle"});
#line 149
this.ScenarioSetup(scenarioInfo);
#line 150
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 151
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.Then("click the \"Abt HRMS Superuser\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt HRMS User", new string[] {
                "Oracle"}, SourceLine=157)]
        public virtual void AbtHRMSUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt HRMS User", new string[] {
                        "Oracle"});
#line 158
this.ScenarioSetup(scenarioInfo);
#line 159
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 160
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.Then("click the \"Abt HRMS User\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt US HR Executive", new string[] {
                "Oracle"}, SourceLine=165)]
        public virtual void AbtUSHRExecutive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt US HR Executive", new string[] {
                        "Oracle"});
#line 166
this.ScenarioSetup(scenarioInfo);
#line 167
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 168
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.Then("click the \"Abt US HR Executive\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 171
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt US HR Manager", new string[] {
                "Oracle"}, SourceLine=174)]
        public virtual void AbtUSHRManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt US HR Manager", new string[] {
                        "Oracle"});
#line 175
this.ScenarioSetup(scenarioInfo);
#line 176
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 177
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.Then("click the \"Abt US HR Manager\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("US Super HRMS Manager", new string[] {
                "Oracle"}, SourceLine=183)]
        public virtual void USSuperHRMSManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("US Super HRMS Manager", new string[] {
                        "Oracle"});
#line 184
this.ScenarioSetup(scenarioInfo);
#line 185
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 186
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.Then("click the \"US Super HRMS Manager\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 189
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("US HRMS Manager", new string[] {
                "Oracle"}, SourceLine=191)]
        public virtual void USHRMSManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("US HRMS Manager", new string[] {
                        "Oracle"});
#line 192
 this.ScenarioSetup(scenarioInfo);
#line 193
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 194
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.Then("click the \"US HRMS Manager\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("US HR Manager", new string[] {
                "Oracle"}, SourceLine=199)]
        public virtual void USHRManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("US HR Manager", new string[] {
                        "Oracle"});
#line 200
this.ScenarioSetup(scenarioInfo);
#line 201
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 202
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
 testRunner.Then("click the \"US HR Manager\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 205
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt US HR Technical Manager", new string[] {
                "Oracle"}, SourceLine=207)]
        public virtual void AbtUSHRTechnicalManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt US HR Technical Manager", new string[] {
                        "Oracle"});
#line 208
this.ScenarioSetup(scenarioInfo);
#line 209
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 210
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 211
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 212
 testRunner.Then("click the \"Abt US HR Technical Manager\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 213
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Abt US HRMS Manager", new string[] {
                "Oracle"}, SourceLine=215)]
        public virtual void AbtUSHRMSManager()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Abt US HRMS Manager", new string[] {
                        "Oracle"});
#line 216
this.ScenarioSetup(scenarioInfo);
#line 217
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 218
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 220
 testRunner.Then("click the \"Abt US HRMS Manager\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 221
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR: Manage Employee Action Forms", new string[] {
                "Oracle"}, SourceLine=223)]
        public virtual void HRManageEmployeeActionForms()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR: Manage Employee Action Forms", new string[] {
                        "Oracle"});
#line 224
this.ScenarioSetup(scenarioInfo);
#line 225
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 226
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 227
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 228
 testRunner.Then("click the \"HR: Manage Employee Action Forms\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 229
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Workflow User Web Applications", new string[] {
                "Oracle"}, SourceLine=232)]
        public virtual void WorkflowUserWebApplications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Workflow User Web Applications", new string[] {
                        "Oracle"});
#line 233
this.ScenarioSetup(scenarioInfo);
#line 234
 testRunner.Given("I have Open Chrome Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 235
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 236
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 237
 testRunner.Then("click the \"Workflow User Web Applications\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 238
 testRunner.Then("I click on all links at the right side menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
