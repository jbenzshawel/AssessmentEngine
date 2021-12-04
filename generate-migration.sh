#!/bin/bash

cd AssessmentEngine.Infrastructure

dotnet ef --startup-project ../AssessmentEngine.Web migrations add $1

cd ../
