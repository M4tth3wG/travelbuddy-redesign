# CLAUDE.md

## Project

TravelBuddy is a mobile trip planner. This repo is a closed university project kept as a portfolio item, based on the original team repo. Prefer small, focused changes. Do not refactor unrelated code.

- `app/`: React Native, Expo SDK 51, expo-router, TypeScript
- `backend/`: ASP.NET Core 8 Minimal API, EF Core, SQL Server, xUnit
- `docs/`: domain docs and requirements in Polish

Keep user-facing text in Polish.

## Commands

### Backend (run from `backend/`)
```bash
dotnet test
dotnet test --filter "FullyQualifiedName~TripsServiceTest"
dotnet run --project TravelBuddyAPI
```

Local stack: run `docker compose up` in `backend/TravelBuddyAPI/`. It needs `MSSQL_SA_PASSWORD`, `GEOAPIFY__KEY`, `COGNITO__AUTHORITY`, `COGNITO__AUDIENCE` and `ASPNETCORE_ENVIRONMENT`.

### App (run from `app/`)
```bash
npm start
npm run lint
npx jest path/to/file
```

## Rules

- Do not read `.env` files.
- Do not push or create pull requests unless asked.
- Use one branch and one topic per task.
- For backend fixes, add a regression test when a unit test can cover the change.
- NBP client tests call the real API and need internet access.

## Backend gotchas

- `Data/ModelBuilderExtension.cs` seeds data with `Guid.NewGuid()`. Adding a migration regenerates all seed rows and produces a huge diff. Do not add a migration unless the task requires a schema change, and warn me first.
- Migrations run on startup through `Database.Migrate()`.
- Tests use EF Core InMemory, so they do not verify SQL translation, transactions or relational constraints.

## App gotchas

- `EXPO_PUBLIC_FEATURE_VERSION` selects UI variant `v1`, `v2` or `v3`. Keep `v1` intact as the baseline.
- All backend calls go through `useAuth().api`, which attaches the Cognito token.