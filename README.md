# SecurityApp

ASP.NET Core MVC app for detecting malicious scripts (SQLi, XSS, etc.), with Google Authenticator-based 2FA.

## Features

- Detects patterns like `select *`, `<script>`, `drop table`
- Web UI to test user input
- Two-Factor Authentication using Google Authenticator
- Clean and well-documented

## How to Run

1. Clone repo
2. Run via Visual Studio (F5)
3. Navigate to `/ScriptCheck` to use detector
