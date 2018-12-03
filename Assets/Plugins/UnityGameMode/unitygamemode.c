#include "gamemode_client.h"

extern "C" int GameModeRequestStart() {
	return gamemode_request_start();
}

extern "C" int GameModeRequestEnd() {
	return gamemode_request_end();
}

extern "C" int GameModeQueryStatus() {
	return gamemode_query_status();
}
