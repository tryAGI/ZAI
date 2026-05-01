#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.z.ai/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.z.ai/openapi.json
autosdk generate openapi.yaml \
  --namespace ZAI \
  --clientClassName ZaiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
