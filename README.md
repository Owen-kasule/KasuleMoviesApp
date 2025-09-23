# Kasule Movies App

ASP.NET Core MVC app based on the Hello World tutorial, enhanced to meet the assignment requirements.

## Features
- Application title updated to “Kasule Movies”
- Movies page with at least three personal favorites
- Listing heading changed to “Kasule’s Favorite Movies”
- Year filter (shows movies from selected year and newer)
- Styling improvement: padding added to input/select/textarea

## Run locally
From the project directory:

```bash
dotnet build
dotnet run
```

Then open:
- http://localhost:5000 (HTTP)
- https://localhost:5001 (HTTPS)

Pages:
- Movies list: http://localhost:5000/Movies
- Filter by year: http://localhost:5000/Movies?year=2010

If you need to force port 5000 in your environment:
```bash
dotnet run --urls http://localhost:5000
```

## Submission checklist
- Title shows “Kasule Movies”
- Movies page heading shows “Kasule’s Favorite Movies”
- At least three movies are listed
- Year filter works (>= selected year)
- Inputs have visible padding

## Notes
Launch profile is set to ports 5000/5001 (see `Properties/launchSettings.json`).
