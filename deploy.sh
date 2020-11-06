#!/bin/bash
echo "Building app..."
yarn --cwd AssessmentEngine.Web/wwwroot/ install
node /home/addison/node_modules/gulp/bin/gulp.js --gulpfile AssessmentEngine.Web/wwwroot/gulpfile.js
dotnet publish --configuration Release

echo "Stopping assessment service..."
systemctl stop assessment.service

echo "Publishing app..."
rm -r /var/www/assessment-engine/*
cp -r AssessmentEngine.Web/bin/Release/netcoreapp3.1/publish/* /var/www/assessment-engine/.
chown -R assessment:assessment /var/www/assessment-engine/*

echo "Starting assessment service..."
systemctl start assessment.service

echo "Publish complete!"
