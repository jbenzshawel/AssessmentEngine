# AssessmentEngine

![Deploy Web App](https://github.com/jbenzshawel/AssessmentEngine/workflows/Deploy%20Web%20App/badge.svg)

Web app for creating and taking tasks/assessments

## AssessmentEngine.Infrastructure 
Due to EF db context / migrations configured oustide startup project use the following commands from the infrastructure project:

Create new migration
```
dotnet ef --startup-project ../AssessmentEngine.Web migrations add MigrationName
```

Running migrations
```
dotnet ef --startup-project ../AssessmentEngine.Web database update        
```
