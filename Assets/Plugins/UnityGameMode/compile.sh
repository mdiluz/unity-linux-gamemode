#!/bin/bash
g++ unitygamemode.c -shared -ldl -o libUnityGameMode.so
nm -C libUnityGameMode.so | grep GameMode
