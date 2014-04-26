------------------------Protect from these types of input-----------------------------------

- wrong datatype
- too many characters
- empty input
- IME input
- regex expressions for student drill screens


------------------------2014 04 22 Changes-----------------------------------

XML schema needs nicer handling
  *exit gracefully
  *possibly log the error or any isolated lines that cause the XML schema to break
  
Feedback strings are limited:
  *to a max of five entries for positive and five entries for negative feedback
  *20 characters long 
  each (currently 30)

tooltips needed on everything!
Pop-out outline on text fields on top of pretty visuals



------------------------2014 04 21 Changes-----------------------------------

Removing a student requires that an active/inactive boolean be added to the XML files.
Result screen no longer has a report of how many units of reward were earned.


------------------------2014 04 17 New Requirements--------------------------
						
						Req 85.0-93.0 added
		
Report Printing Functionality -> PARENT, REPORT, and STUDENT SUMMARY reports
	implementation:  object expected?
	Need Column Headers printed on EVERY page for Summary report (ReportPrinter.cs)
	Reports to be PRINTED in English+Spanish
	
  
  Import student records
  
  Rewards (Bananas on UI, integer internally :D)
  
  
  
------------------------EVERY SESSION, DO THESE THINGS-----------------------

	*** Make sure a changelog entry exists for all modified files
	*** Make sure a header with /// (generates nice header) and entries for DESCRIPTION, AUTHOR_AND_DATE exists for every function
	*** Update readme.txt
	*** Publish zipped Executable and readme.txt to SP             (Math Monkeys_3_#_#_#.zip)

------------------------Quality (non-requirements) TODO----------------------
	
	**  Prevent bad input on front-end (disable IME input, limit what kinds of input, (I'm sure there's more))
	**  Prevent bad input on back-end (only allow ascii (not extended ascii), (I'm sure there's more))
	**  All forms and controls behave in the typical windows way including
		** On form load, mouse focus on appropriate control
		**  Enter button from any field on a form submits data
		**  Tab button works normally (and without moving onto invisible/grayed-out controls)
		**  Tabbed interface can be switched around using Shift-Tab and Ctrl-Shift-Tab
		**  Entering bad data into a field deletes the bad data upon submission and moves focus to that field
		**  Ctrl-a, -c, -x, -v should work normally
	**  Rikki's Miscellaneous Requirements:
		** Icon on every form
		** (Maximum of) Three form sizes
		** Same font on all Student screens.  Same font on all Admin screens
		** One taskbar icon regardless of how many screens are visible
	**  ADHERE CLOSELY ENOUGH TO RIKKI'S LECTURES ON:
		**  following use case Flow
		**  Affordance  --  How a form looks suggests Function
		**  Visibility  --  Only what functionality is available is visible (not grayed-out, typically)
		**  Goal Directed Design  (based on a persona (Jamie) or a special education student)
		**  Searching for names are not case sensitive.  Passwords are case sensitive.
		**  Password input hidden
		**  Flow from right to left, then down.  Never move to left or back up.  Find another soln before saying it's impossible.
		**  Design for your user, especially when you're a programmer and the target audience is children
		**  Deleting user => just mark them as inactive
		**  Permanently deleting most anything => give a very scary warning message
		**  focus move around w/ visual indication.  (Can use this to guide flow)
		**  when it's a permission issue, don't give them the option.  When not, message box/visual indication of why you can't do that
		**  Avoid windows within windows within windows within....
		**  Nothing cut off in spreadsheets or anything else that can hold variable-length data
		**  For spreadsheets especially, fit the width of columns to data and/or labels and/or type of data!
		**  Don't allow UI controls to do extra things.  e.g. Login box that allows you to type into it
	
	
------------------------PROGRAMMER IMPLEMENTATION TODO-----------------------
	
	http://www.codeproject.com/Articles/12514/Multi-Document-Interface-MDI-tab-page-browsing-wit
		
	Create/Set up reports form for the other reports that don't yet have a form

	Print function implementation
		
	Create new form that reports how successful an import was/prompts user to select what to do in case of conflicts
	
	FOR IMPLEMENTING THE REWARD SYSTEM:
o   One banana per correct problem (Default)
o   Admin settings
§  Number of bananas per correct problems
§  Number of bananas per Incorrect problems
§  Number of bananas per goal percent achieved
-          We are creating printed reports
o   printed summary report
o   printed detail report
o   printed parent report
§  report in English
§  report in Spanish
-          Import Student records from a file
-          Background images
-          Reordering Assignments
-          Admin options for Feedback
o   Text displayed
o   Color of the text
o   Sound possibly


HAVE TO ADOPT FLETCHERS XML FILE NAMING CONVENTNIONS
		last name, first name    (allow the first name to contain multiple fields)   (if using different format for excel import features, then document inside the README that the format for import is as needed by the teacher.  Also document as a kindof/notreally requirement inside the external interfaces section of the SRS)

- The division without whole-number-answers doesn't accept a range large enough to ensure 2 (should be an arbitrarily defined in the SRS!)
    **Implementation Note:  Epsilon is too SMALL
	
	
	
------------------------PROGRAMMER REFACTORING TODO-----------------------

Copy-paste re-enabled on login form.  (Disabling IME control prevents users from typing non-english characters into the box)


refactor:      if(......==true)
					return true;
				else
					return false;				
into:
		return (......==true);            ...and, in general, convert trivial code to the concise version
			
	
	Add changelogs so they aren't forgotten, just add your name as necessary
		Add changelogs to the code portion of all frmBlahBlah.cs files
		
	rightClick -> extract method  ?? makes it reusable

	look for repeated code, refactor into a single place
	
	classes that do too much get broken into smaller classes
		** MMControl.cs
		** FileHandler.cs
		
	Lots and Lots of refactoring  (use her guide + Arun's PPT)
	
	refactor names into conventional C# names (Naming conventions for GUI controls on dotnetspider.com)
	
	Match entire codebase to C# Coding Standards (dotnetspider.com)

	#Region as appropriate
	
	uncouple functions too tightly coupled to UI classes  (UserLogin(), ...)
	
	Things common to all forms, or with a setting for all student and admin forms, need to be 
	point to settings file (project->settings, actually stored in app.config)
	
	Should restructure MMControl into UseCase-based Control classes (NEED NEW USE CASE DIAGRAM)

	
	
---------------------COMPLETED TASKS---------------------------------
	19 April, 2014
change all spelling of Depracated to Deprecated

		 
	17 April, 2014
Used the same namespace for all classes, excluding forms which are in sub-namespace "forms"
Implementation details for ReportPrinter class (possible creation of importable .csv or .xls)
Start program => focus on USER SELECT COMBOBOX
rename frmAddStudent to frmAddUser
Logout works from Admin control.
UI forms load