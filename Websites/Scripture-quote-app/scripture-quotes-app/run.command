#!/usr/bin/env bash
# Double-click this file to start the app
set -e
cd "$(dirname "$0")"
# Ensure Terminal opens in a login shell so venv activation works on macOS
/usr/bin/env bash ./run.sh
