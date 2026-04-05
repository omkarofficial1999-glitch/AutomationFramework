# Automation Framework

![Selenium Tests](https://github.com/omkarofficial1999-glitch/AutomationFramework/actions/workflows/selenium-tests.yml/badge.svg)

## About
Selenium C# test automation framework built with:
- Selenium WebDriver
- NUnit
- Page Object Model
- GitHub Actions CI/CD

## How to run
dotnet test

## Structure Explanation
- Pages folder has Page Object classes with locators and methods. 
- Utilities has BaseTest and DriverManager for browser setup. 
- Tests has all test classes that inherit BaseTest. 
- The yml file in .github/workflows runs all tests automatically on every push via GitHub Actions.
