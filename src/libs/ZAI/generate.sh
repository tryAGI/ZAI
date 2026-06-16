#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://docs.z.ai/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://docs.z.ai/openapi.json
autosdk generate openapi.yaml \
  --namespace ZAI \
  --clientClassName ZaiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
