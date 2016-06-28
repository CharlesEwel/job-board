# Job Board

#### A simple job board webapp.

#### Made by Carl Egbert and Charles Ewel

## Description

This webapp allows users to post jobs to a list, then view them all or search them based on certain criteria.

## Instructions

* Clone the repository
* In the console, run ">dnu restore" to set up dependencies
* In the console, run ">dnx kestrel" to set up your local server
* Navigate to localhost:5004 in your web browser

## Specs

The program should handle: | Example Input | Example Output
----- | ----- | -----
Add a single job | Title: Jr. Web Developer Description: Build webapps using HTML, CSS, JavaScript, and C#. Contact Info: John Smith, 503-111-1111, johnsmith@email | Title: Jr. Web Developer Description: Build webapps using HTML, CSS, JavaScript, and C#. Contact Info: John Smith, 503-111-1111, johnsmith@email
Create a List of Jobs|Multiple Inputs like the above entered|Jobs: Jr Web Developer, QA Tester, Sales Associate
Display details about job on click|User clicks a job title from list|Description and Contact Info appear
Search by keyword||

## Technologies Used

* C#
* ASP.NET Nancy View Engine
* ASP.NET Razor View Engine

## Known Bugs

None

### License

Licensed under the MIT License.
