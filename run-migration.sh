#!/bin/bash

cd AssessmentEngine.Infrastructure

dotnet ef --startup-project ../AssessmentEngine.Web database update

cd ../
