#!groovy

pipeline {
    agent any
    environment {
        VERSION = '1.0'
    }
    stages {
        
        
        stage ('Restore packages') {
            steps {
                sh "dotnet restore ${workspace}\\WiredBrain.CustomerPortal.AspNet.sln"
            }
        }
    }
}
