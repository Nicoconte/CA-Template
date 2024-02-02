<h1>EasyCA-Template</h1>
<h3><i>This template is a highly streamlined version inspired by Jason Taylor's Clean Architecture Template . The aim is to provide you with a foundational template that can be easily expanded based on your specific needs, allowing your project to scale seamlessly with your requirements.</i></h3>

<h5>Jason Taylor's CA Template: https://github.com/jasontaylordev/CleanArchitecture </h5>

<h1>Installation Guide</h1>

<h3>1. Clone the project with the version you intend to use</h3>

<h5>Replace `net-8.0` with the desired version.</h5>

```bash
git clone --branch net-8.0 https://github.com/Nicoconte/EasyCA-Template
```

<h3>2. Navigate to the Cloned Folder and Install the Template</h3>

<h5>Open a terminal in the cloned folder and install the template using the following command:</h5>

```
dotnet new install .
```

<h3>3. Create a Project</h3>

<h5>Use the following command to create a new project, replacing YourProjectName with the desired name:</h5>

```
dotnet new eca -n YourProjectName
```

<h4>Note: The project is created with a default SQLite database and includes some example "use cases," entities, and DTOs.</h4>

<br>

<h1>Database commands</h1>

<h5>To initialize and update the database, run the following commands:</h5>

```
dotnet ef migrations add "InitDatabase" --project src\Infrastructure --startup-project src\WebAPI --output-dir Migrations
```

```
dotnet ef database update --project src\Infrastructure --startup-project src\WebAPI
```
