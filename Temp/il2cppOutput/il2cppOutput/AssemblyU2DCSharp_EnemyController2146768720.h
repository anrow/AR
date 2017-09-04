#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EnemyController
struct  EnemyController_t2146768720  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject EnemyController::enemy
	GameObject_t1756533147 * ___enemy_2;
	// UnityEngine.Vector3 EnemyController::spwanPoint
	Vector3_t2243707580  ___spwanPoint_3;

public:
	inline static int32_t get_offset_of_enemy_2() { return static_cast<int32_t>(offsetof(EnemyController_t2146768720, ___enemy_2)); }
	inline GameObject_t1756533147 * get_enemy_2() const { return ___enemy_2; }
	inline GameObject_t1756533147 ** get_address_of_enemy_2() { return &___enemy_2; }
	inline void set_enemy_2(GameObject_t1756533147 * value)
	{
		___enemy_2 = value;
		Il2CppCodeGenWriteBarrier(&___enemy_2, value);
	}

	inline static int32_t get_offset_of_spwanPoint_3() { return static_cast<int32_t>(offsetof(EnemyController_t2146768720, ___spwanPoint_3)); }
	inline Vector3_t2243707580  get_spwanPoint_3() const { return ___spwanPoint_3; }
	inline Vector3_t2243707580 * get_address_of_spwanPoint_3() { return &___spwanPoint_3; }
	inline void set_spwanPoint_3(Vector3_t2243707580  value)
	{
		___spwanPoint_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
