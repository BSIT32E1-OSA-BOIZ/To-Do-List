# To do list app with customization and overview of tasks

User Stories and Separate Concerns for a To-Do List in MVC As a user, I want to...

Add tasks to my list:

1. Create new tasks by specifying a description and optionally setting a due date or priority level. 

2. View all tasks:

See a list of all my existing tasks, including their descriptions, due dates (if set), and completion status. Optionally, filter or search tasks by keyword, completion status, or date range. 


3. Edit existing tasks:

Edit the description, or due date. 

4. Delete tasks:

Remove unwanted or finished tasks from the list. 



Separate Concerns:

Model:
Task class: Stores information about each task (description, due date, priority level, completion status, etc.). 2. Controller:

TaskController: Handles requests for adding, editing, deleting, and managing task lists. 3. View:

Tasks view: Displays a list of all tasks with descriptions, due dates (if set), and completion status indicators. CreateTask view (optional): Provides a form for creating new tasks. EditTask view (optional): Provides a form for editing existing tasks. _Layout view: Provides the overall website layout and navigation. 4. Data Access:

Implement a data access layer (e.g., using Entity Framework Core) to store and retrieve tasks from a database. This allows persisting user data across sessions and keeping track of completed tasks. 5. Services (Optional):

Implement services for specific tasks like sending reminder notifications for upcoming due dates (using external services or scheduled jobs). This is a basic set of user stories and separate concerns for the To-Do List. You can extend or modify it based on your specific requirements and desired functionalities.

Here are some additional features you could consider:

Categorize tasks by assigning them to different categories. Share task lists with other users and collaborate on completing tasks together (requires additional user management and access control functionalities). Mark tasks as recurring to create repeating reminders at specific intervals.
