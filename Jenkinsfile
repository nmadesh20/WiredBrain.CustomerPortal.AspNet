#!groovy

pipeline {
    agent none
    environment {
        VERSION = '1.0'
    }
    stages {
        stage ('Clean Workspace') {
            steps {
                cleanWs()
            }
        }
        stage ('Git Checkout') {
            steps {
                git branch: 'master', credentialsId: "${GitID}", url: 'https://github.com/nmadesh20/WiredBrain.CustomerPortal.AspNet'
            }
        }
        stage ('Restore packages') {
            steps {
                bat "dotnet restore ${workspace}\\Demo2\\WiredBrain.sln"
            }
        }
    }
}
