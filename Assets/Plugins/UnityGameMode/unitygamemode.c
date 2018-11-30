#include "gamemode_client.h"

extern "C" int UnityEnterGameMode() {
	gamemode_request_start();
}

extern "C" int UnityExitGameMode() {
	gamemode_request_end();
}
