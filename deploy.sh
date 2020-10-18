#!/bin/bash
echo "Building app..."
dotnet publish --configuration Release

echo "Stopping assessment service..."
systemctl stop assessment.service

echo "Publishing app..."
rm -r /var/www/assessment-engine/*
cp AssessmentEngine.Web/bin/Release/netcoreapp3.1/publish/* /var/www/assessment-engine/.
chown -R assessment:assessment /var/www/assessment-engine/*

echo "Starting assessment service..."
systemctl start assessment.service

echo "Publish complete!"