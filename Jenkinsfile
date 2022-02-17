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
        stage ('Checkout') {
            steps{
            checkout([$class: 'GitSCM', branches: [[name: '*/master']], extensions: [], userRemoteConfigs: [[]]])
            }
        }
        
        stage ('Restore packages') {
            steps {
                sh "dotnet restore ${workspace}\\Demo2\\WiredBrain.sln"
            }
        }
    }
}
