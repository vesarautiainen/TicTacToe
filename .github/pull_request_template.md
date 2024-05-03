<?xml version="1.0" encoding="utf-8"?>
<VSTemplate Version="3.0.0" Type="Project" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
  <TemplateData>
    <Name>My C# Project Template</Name>
    <Description>A custom C# project template</Description>
    <Icon>icon.png</Icon>
    <ProjectType>CSharp</ProjectType>
  </TemplateData>
  <TemplateContent>
    <Project File="MyProject.csproj">
      <!-- Add other files and folders here -->
      <Folder Name="src">
        <ProjectItem ReplaceParameters="true">Program.cs</ProjectItem>
        <!-- Add more source files -->
      </Folder>
      <Folder Name="tests">
        <ProjectItem ReplaceParameters="true">Test.cs</ProjectItem>
        <!-- Add test files -->
      </Folder>
    </Project>
  </TemplateContent>
</VSTemplate>
