#!groovy

pipeline {
    agent any
    environment {
        VERSION = '1.0'
    }
    stages {
        stage ('Clean Workspace') {
            steps {
                cleanWs()
            }
        }
        
        stage ('Restore packages') {
            steps {
                sh "dotnet restore ${workspace}\\Demo2\\WiredBrain.sln"
            }
        }
    }
}
