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
// UnityEngine.UI.Button
struct Button_t2872111280;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// webCamScript
struct  webCamScript_t1312139898  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject webCamScript::webCameraPlane
	GameObject_t1756533147 * ___webCameraPlane_2;
	// UnityEngine.UI.Button webCamScript::fireButton
	Button_t2872111280 * ___fireButton_3;
	// UnityEngine.Vector3 webCamScript::offset
	Vector3_t2243707580  ___offset_4;

public:
	inline static int32_t get_offset_of_webCameraPlane_2() { return static_cast<int32_t>(offsetof(webCamScript_t1312139898, ___webCameraPlane_2)); }
	inline GameObject_t1756533147 * get_webCameraPlane_2() const { return ___webCameraPlane_2; }
	inline GameObject_t1756533147 ** get_address_of_webCameraPlane_2() { return &___webCameraPlane_2; }
	inline void set_webCameraPlane_2(GameObject_t1756533147 * value)
	{
		___webCameraPlane_2 = value;
		Il2CppCodeGenWriteBarrier(&___webCameraPlane_2, value);
	}

	inline static int32_t get_offset_of_fireButton_3() { return static_cast<int32_t>(offsetof(webCamScript_t1312139898, ___fireButton_3)); }
	inline Button_t2872111280 * get_fireButton_3() const { return ___fireButton_3; }
	inline Button_t2872111280 ** get_address_of_fireButton_3() { return &___fireButton_3; }
	inline void set_fireButton_3(Button_t2872111280 * value)
	{
		___fireButton_3 = value;
		Il2CppCodeGenWriteBarrier(&___fireButton_3, value);
	}

	inline static int32_t get_offset_of_offset_4() { return static_cast<int32_t>(offsetof(webCamScript_t1312139898, ___offset_4)); }
	inline Vector3_t2243707580  get_offset_4() const { return ___offset_4; }
	inline Vector3_t2243707580 * get_address_of_offset_4() { return &___offset_4; }
	inline void set_offset_4(Vector3_t2243707580  value)
	{
		___offset_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
