﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuestEditor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuestEditor.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace ParallelZodiac
        ///{
        ///    public class Detail
        ///    {
        ///        public enum DetailState
        ///        {
        ///            //Locked = 0,
        ///            InProgress = 0,
        ///            Completed,
        ///            Failed
        ///        }
        ///		public string StateKey = &quot;_STATE&quot;;
        ///        public int ID;
        ///        public int StepID;
        ///        public GameObject ActiveEntity;
        ///        public GameObject PassiveEntity;
        ///        public int Action;
        ///        public int Amount;
        ///        public float TimerLength;
        ///        public DetailState State [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Detail {
            get {
                return ResourceManager.GetString("Detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Linq;
        ///
        ///namespace ParallelZodiac
        ///{
        ///    public class Quest
        ///    {
        ///		protected string StepKey = &quot;_CURRENT_STEP&quot;;
        ///        protected List&lt;Step&gt; Steps;
        ///        public int QuestID;
        ///        public string QuestName;
        ///        public string QuestDescription;
        ///        public int CurrentStepID;
        ///        public string Version;
        ///
        ///        public Quest()
        ///        {
        ///            Steps = new List&lt;Step&gt;();
        ///        }
        ///
        ///        public void FailQuest()
        ///        {
        ///            //TODO: Display failure for al [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Quest {
            get {
                return ResourceManager.GetString("Quest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace ParallelZodiac
        ///{
        ///    class [[QUESTCLASS]] : Quest
        ///    {
        ///        public [[QUESTCLASS]]()
        ///        {
        ///            QuestID          = [[QUESTID]];
        ///			StepKey          = QuestID.ToString() + StepKey;
        ///            QuestName        = &quot;[[QUESTNAME]]&quot;;
        ///            QuestDescription = &quot;[[QUESTDESCRIPTION]]&quot;;
        ///            Version          = &quot;[[QUESTVERSION]]&quot;;
        ///            CurrentStepID    = GetInt(StepKey, 0);
        ///            Steps.Add(CurrentStep);
        ///
        ///			CreateFirstStep();
        ///            CreateSteps();
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QuestTemplate {
            get {
                return ResourceManager.GetString("QuestTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Collections.Generic;
        ///
        ///namespace ParallelZodiac
        ///{
        ///    public class Step
        ///    {
        ///		public string AttemptsKey = &quot;_ATTEMPTS_COMPLETED&quot;&quot;;
        ///        public int ID;
        ///        public int QuestID;
        ///        public string StepName;
        ///        public string Dialogue;
        ///        public string ExceptionDialogue;
        ///        public bool UseGeneric;
        ///        public bool UseTyped;
        ///        public Dictionary&lt;GameObject, int&gt; Reward;
        ///        public List&lt;Detail&gt; Details;
        ///        public int AmountOfAttempts;
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Step {
            get {
                return ResourceManager.GetString("Step", resourceCulture);
            }
        }
    }
}
