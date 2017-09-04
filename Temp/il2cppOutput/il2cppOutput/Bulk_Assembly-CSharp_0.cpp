#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

// collisionScript
struct collisionScript_t3230582939;
// UnityEngine.Collider
struct Collider_t3497673348;
// EnemyController
struct EnemyController_t2146768720;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// System.Object
struct Il2CppObject;
// enemyScript
struct enemyScript_t3437882687;
// System.Collections.IEnumerator
struct IEnumerator_t1466026749;
// enemyScript/<Move>c__Iterator0
struct U3CMoveU3Ec__Iterator0_t3321662626;
// GameStatus
struct GameStatus_t1708871372;
// System.String
struct String_t;
// MainGamePanel
struct MainGamePanel_t3849144277;
// PanelState
struct PanelState_t3008758799;
// webCamScript
struct webCamScript_t1312139898;
// UnityEngine.MeshRenderer
struct MeshRenderer_t1268241104;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array3829468939.h"
#include "AssemblyU2DCSharp_U3CModuleU3E3783534214.h"
#include "AssemblyU2DCSharp_U3CModuleU3E3783534214MethodDeclarations.h"
#include "AssemblyU2DCSharp_collisionScript3230582939.h"
#include "AssemblyU2DCSharp_collisionScript3230582939MethodDeclarations.h"
#include "mscorlib_System_Void1841601450.h"
#include "UnityEngine_UnityEngine_MonoBehaviour1158329972MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Collider3497673348.h"
#include "mscorlib_System_Type1303803226MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Resources339470017MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Object1021602117MethodDeclarations.h"
#include "UnityEngine_UnityEngine_GameObject1756533147MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Component3819376471MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Transform3275118058MethodDeclarations.h"
#include "UnityEngine_UnityEngine_GameObject1756533147.h"
#include "mscorlib_System_String2029220233.h"
#include "mscorlib_System_Type1303803226.h"
#include "mscorlib_System_RuntimeTypeHandle2330101084.h"
#include "UnityEngine_UnityEngine_Object1021602117.h"
#include "UnityEngine_UnityEngine_Transform3275118058.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"
#include "mscorlib_System_Single2076509932.h"
#include "UnityEngine_ArrayTypes.h"
#include "AssemblyU2DCSharp_EnemyController2146768720.h"
#include "AssemblyU2DCSharp_EnemyController2146768720MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Random1170710517MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Quaternion4030073918MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Vector32243707580MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Quaternion4030073918.h"
#include "AssemblyU2DCSharp_enemyScript3437882687.h"
#include "AssemblyU2DCSharp_enemyScript3437882687MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Coroutine2299508840.h"
#include "UnityEngine_UnityEngine_Time31991979MethodDeclarations.h"
#include "AssemblyU2DCSharp_enemyScript_U3CMoveU3Ec__Iterato3321662626MethodDeclarations.h"
#include "AssemblyU2DCSharp_enemyScript_U3CMoveU3Ec__Iterato3321662626.h"
#include "mscorlib_System_Object2689449295MethodDeclarations.h"
#include "mscorlib_System_Boolean3825574718.h"
#include "UnityEngine_UnityEngine_WaitForSeconds3839502067MethodDeclarations.h"
#include "mscorlib_System_UInt322149682021.h"
#include "mscorlib_System_Int322071877448.h"
#include "UnityEngine_UnityEngine_WaitForSeconds3839502067.h"
#include "mscorlib_System_Object2689449295.h"
#include "mscorlib_System_NotSupportedException1793819818MethodDeclarations.h"
#include "mscorlib_System_NotSupportedException1793819818.h"
#include "AssemblyU2DCSharp_GameStatus1708871372.h"
#include "AssemblyU2DCSharp_GameStatus1708871372MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Debug1368543263MethodDeclarations.h"
#include "UnityEngine_UnityEngine_SceneManagement_SceneManager90660965MethodDeclarations.h"
#include "AssemblyU2DCSharp_MainGamePanel3849144277.h"
#include "AssemblyU2DCSharp_MainGamePanel3849144277MethodDeclarations.h"
#include "AssemblyU2DCSharp_Panel1787746694.h"
#include "AssemblyU2DCSharp_Panel1787746694MethodDeclarations.h"
#include "AssemblyU2DCSharp_Panel_GAME_PHASE917030329.h"
#include "AssemblyU2DCSharp_Panel_GAME_PHASE917030329MethodDeclarations.h"
#include "AssemblyU2DCSharp_Panel_TITLE_PHASE2762430331.h"
#include "AssemblyU2DCSharp_Panel_TITLE_PHASE2762430331MethodDeclarations.h"
#include "AssemblyU2DCSharp_PanelState3008758799.h"
#include "AssemblyU2DCSharp_PanelState3008758799MethodDeclarations.h"
#include "AssemblyU2DCSharp_webCamScript1312139898.h"
#include "AssemblyU2DCSharp_webCamScript1312139898MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Application354826772MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Input1785128008MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Gyroscope1705362817MethodDeclarations.h"
#include "UnityEngine_UI_UnityEngine_UI_Button2872111280MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Events_UnityAction4025899511MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Events_UnityEvent408735097MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WebCamTexture1079476942MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Renderer257310565MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Material193706927MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WebCamTexture1079476942.h"
#include "UnityEngine_UnityEngine_Gyroscope1705362817.h"
#include "UnityEngine_UI_UnityEngine_UI_Button2872111280.h"
#include "UnityEngine_UI_UnityEngine_UI_Button_ButtonClicked2455055323.h"
#include "UnityEngine_UnityEngine_Events_UnityAction4025899511.h"
#include "mscorlib_System_IntPtr2504060609.h"
#include "UnityEngine_UnityEngine_MeshRenderer1268241104.h"
#include "UnityEngine_UnityEngine_Material193706927.h"
#include "UnityEngine_UnityEngine_Texture2243626319.h"
#include "UnityEngine_UnityEngine_Camera189460977MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Rigidbody4233889191MethodDeclarations.h"
#include "UnityEngine_UnityEngine_AudioSource1135106623MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Rigidbody4233889191.h"
#include "UnityEngine_UnityEngine_Camera189460977.h"
#include "UnityEngine_UnityEngine_AudioSource1135106623.h"
#include "UnityEngine_UnityEngine_Component3819376471.h"

// !!0 UnityEngine.Object::Instantiate<System.Object>(!!0,UnityEngine.Vector3,UnityEngine.Quaternion)
extern "C"  Il2CppObject * Object_Instantiate_TisIl2CppObject_m3829784634_gshared (Il2CppObject * __this /* static, unused */, Il2CppObject * p0, Vector3_t2243707580  p1, Quaternion_t4030073918  p2, const MethodInfo* method);
#define Object_Instantiate_TisIl2CppObject_m3829784634(__this /* static, unused */, p0, p1, p2, method) ((  Il2CppObject * (*) (Il2CppObject * /* static, unused */, Il2CppObject *, Vector3_t2243707580 , Quaternion_t4030073918 , const MethodInfo*))Object_Instantiate_TisIl2CppObject_m3829784634_gshared)(__this /* static, unused */, p0, p1, p2, method)
// !!0 UnityEngine.Object::Instantiate<UnityEngine.GameObject>(!!0,UnityEngine.Vector3,UnityEngine.Quaternion)
#define Object_Instantiate_TisGameObject_t1756533147_m3064851704(__this /* static, unused */, p0, p1, p2, method) ((  GameObject_t1756533147 * (*) (Il2CppObject * /* static, unused */, GameObject_t1756533147 *, Vector3_t2243707580 , Quaternion_t4030073918 , const MethodInfo*))Object_Instantiate_TisIl2CppObject_m3829784634_gshared)(__this /* static, unused */, p0, p1, p2, method)
// !!0 UnityEngine.GameObject::GetComponent<System.Object>()
extern "C"  Il2CppObject * GameObject_GetComponent_TisIl2CppObject_m2650145732_gshared (GameObject_t1756533147 * __this, const MethodInfo* method);
#define GameObject_GetComponent_TisIl2CppObject_m2650145732(__this, method) ((  Il2CppObject * (*) (GameObject_t1756533147 *, const MethodInfo*))GameObject_GetComponent_TisIl2CppObject_m2650145732_gshared)(__this, method)
// !!0 UnityEngine.GameObject::GetComponent<UnityEngine.MeshRenderer>()
#define GameObject_GetComponent_TisMeshRenderer_t1268241104_m3528968632(__this, method) ((  MeshRenderer_t1268241104 * (*) (GameObject_t1756533147 *, const MethodInfo*))GameObject_GetComponent_TisIl2CppObject_m2650145732_gshared)(__this, method)
// !!0 UnityEngine.GameObject::GetComponent<UnityEngine.Rigidbody>()
#define GameObject_GetComponent_TisRigidbody_t4233889191_m1060888193(__this, method) ((  Rigidbody_t4233889191 * (*) (GameObject_t1756533147 *, const MethodInfo*))GameObject_GetComponent_TisIl2CppObject_m2650145732_gshared)(__this, method)
// !!0 UnityEngine.Component::GetComponent<System.Object>()
extern "C"  Il2CppObject * Component_GetComponent_TisIl2CppObject_m4109961936_gshared (Component_t3819376471 * __this, const MethodInfo* method);
#define Component_GetComponent_TisIl2CppObject_m4109961936(__this, method) ((  Il2CppObject * (*) (Component_t3819376471 *, const MethodInfo*))Component_GetComponent_TisIl2CppObject_m4109961936_gshared)(__this, method)
// !!0 UnityEngine.Component::GetComponent<UnityEngine.AudioSource>()
#define Component_GetComponent_TisAudioSource_t1135106623_m3920278003(__this, method) ((  AudioSource_t1135106623 * (*) (Component_t3819376471 *, const MethodInfo*))Component_GetComponent_TisIl2CppObject_m4109961936_gshared)(__this, method)
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void collisionScript::.ctor()
extern "C"  void collisionScript__ctor_m3689404142 (collisionScript_t3230582939 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void collisionScript::Start()
extern "C"  void collisionScript_Start_m92740898 (collisionScript_t3230582939 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void collisionScript::Update()
extern "C"  void collisionScript_Update_m3021642267 (collisionScript_t3230582939 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void collisionScript::OnTriggerEnter(UnityEngine.Collider)
extern const Il2CppType* GameObject_t1756533147_0_0_0_var;
extern Il2CppClass* Type_t_il2cpp_TypeInfo_var;
extern Il2CppClass* Object_t1021602117_il2cpp_TypeInfo_var;
extern Il2CppClass* GameObject_t1756533147_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral1463906364;
extern Il2CppCodeGenString* _stringLiteral1875862075;
extern Il2CppCodeGenString* _stringLiteral1656409327;
extern Il2CppCodeGenString* _stringLiteral1253124800;
extern Il2CppCodeGenString* _stringLiteral2819208741;
extern Il2CppCodeGenString* _stringLiteral2415924214;
extern const uint32_t collisionScript_OnTriggerEnter_m3924630858_MetadataUsageId;
extern "C"  void collisionScript_OnTriggerEnter_m3924630858 (collisionScript_t3230582939 * __this, Collider_t3497673348 * ___col0, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (collisionScript_OnTriggerEnter_m3924630858_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_t1756533147 * V_0 = NULL;
	GameObject_t1756533147 * V_1 = NULL;
	GameObject_t1756533147 * V_2 = NULL;
	GameObject_t1756533147 * V_3 = NULL;
	GameObject_t1756533147 * V_4 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_0 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(GameObject_t1756533147_0_0_0_var), /*hidden argument*/NULL);
		Object_t1021602117 * L_1 = Resources_Load_m243305716(NULL /*static, unused*/, _stringLiteral1463906364, L_0, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_t1021602117 * L_2 = Object_Instantiate_m2439155489(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
		V_0 = ((GameObject_t1756533147 *)IsInstSealed(L_2, GameObject_t1756533147_il2cpp_TypeInfo_var));
		GameObject_t1756533147 * L_3 = V_0;
		NullCheck(L_3);
		Transform_t3275118058 * L_4 = GameObject_get_transform_m909382139(L_3, /*hidden argument*/NULL);
		Transform_t3275118058 * L_5 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		NullCheck(L_5);
		Vector3_t2243707580  L_6 = Transform_get_position_m1104419803(L_5, /*hidden argument*/NULL);
		NullCheck(L_4);
		Transform_set_position_m2469242620(L_4, L_6, /*hidden argument*/NULL);
		Collider_t3497673348 * L_7 = ___col0;
		NullCheck(L_7);
		GameObject_t1756533147 * L_8 = Component_get_gameObject_m3105766835(L_7, /*hidden argument*/NULL);
		Object_Destroy_m4145850038(NULL /*static, unused*/, L_8, /*hidden argument*/NULL);
		GameObject_t1756533147 * L_9 = V_0;
		Object_Destroy_m4279412553(NULL /*static, unused*/, L_9, (2.0f), /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_10 = GameObject_FindGameObjectsWithTag_m2154478296(NULL /*static, unused*/, _stringLiteral1875862075, /*hidden argument*/NULL);
		NullCheck(L_10);
		if ((((int32_t)((int32_t)(((Il2CppArray *)L_10)->max_length)))))
		{
			goto IL_00d9;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_11 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(GameObject_t1756533147_0_0_0_var), /*hidden argument*/NULL);
		Object_t1021602117 * L_12 = Resources_Load_m243305716(NULL /*static, unused*/, _stringLiteral1656409327, L_11, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_t1021602117 * L_13 = Object_Instantiate_m2439155489(NULL /*static, unused*/, L_12, /*hidden argument*/NULL);
		V_1 = ((GameObject_t1756533147 *)IsInstSealed(L_13, GameObject_t1756533147_il2cpp_TypeInfo_var));
		Type_t * L_14 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(GameObject_t1756533147_0_0_0_var), /*hidden argument*/NULL);
		Object_t1021602117 * L_15 = Resources_Load_m243305716(NULL /*static, unused*/, _stringLiteral1253124800, L_14, /*hidden argument*/NULL);
		Object_t1021602117 * L_16 = Object_Instantiate_m2439155489(NULL /*static, unused*/, L_15, /*hidden argument*/NULL);
		V_2 = ((GameObject_t1756533147 *)IsInstSealed(L_16, GameObject_t1756533147_il2cpp_TypeInfo_var));
		Type_t * L_17 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(GameObject_t1756533147_0_0_0_var), /*hidden argument*/NULL);
		Object_t1021602117 * L_18 = Resources_Load_m243305716(NULL /*static, unused*/, _stringLiteral2819208741, L_17, /*hidden argument*/NULL);
		Object_t1021602117 * L_19 = Object_Instantiate_m2439155489(NULL /*static, unused*/, L_18, /*hidden argument*/NULL);
		V_3 = ((GameObject_t1756533147 *)IsInstSealed(L_19, GameObject_t1756533147_il2cpp_TypeInfo_var));
		Type_t * L_20 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(GameObject_t1756533147_0_0_0_var), /*hidden argument*/NULL);
		Object_t1021602117 * L_21 = Resources_Load_m243305716(NULL /*static, unused*/, _stringLiteral2415924214, L_20, /*hidden argument*/NULL);
		Object_t1021602117 * L_22 = Object_Instantiate_m2439155489(NULL /*static, unused*/, L_21, /*hidden argument*/NULL);
		V_4 = ((GameObject_t1756533147 *)IsInstSealed(L_22, GameObject_t1756533147_il2cpp_TypeInfo_var));
	}

IL_00d9:
	{
		GameObject_t1756533147 * L_23 = Component_get_gameObject_m3105766835(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_Destroy_m4145850038(NULL /*static, unused*/, L_23, /*hidden argument*/NULL);
		return;
	}
}
// System.Void EnemyController::.ctor()
extern "C"  void EnemyController__ctor_m1153179309 (EnemyController_t2146768720 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void EnemyController::Start()
extern Il2CppClass* Object_t1021602117_il2cpp_TypeInfo_var;
extern const MethodInfo* Object_Instantiate_TisGameObject_t1756533147_m3064851704_MethodInfo_var;
extern const uint32_t EnemyController_Start_m2470974037_MetadataUsageId;
extern "C"  void EnemyController_Start_m2470974037 (EnemyController_t2146768720 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (EnemyController_Start_m2470974037_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t2243707580  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Vector3_t2243707580 * L_0 = __this->get_address_of_spwanPoint_3();
		float L_1 = L_0->get_x_1();
		Vector3_t2243707580 * L_2 = __this->get_address_of_spwanPoint_3();
		float L_3 = L_2->get_x_1();
		float L_4 = Random_Range_m2884721203(NULL /*static, unused*/, ((-L_1)), L_3, /*hidden argument*/NULL);
		Vector3_t2243707580 * L_5 = __this->get_address_of_spwanPoint_3();
		float L_6 = L_5->get_y_2();
		Vector3_t2243707580 * L_7 = __this->get_address_of_spwanPoint_3();
		float L_8 = L_7->get_y_2();
		float L_9 = Random_Range_m2884721203(NULL /*static, unused*/, ((-L_6)), L_8, /*hidden argument*/NULL);
		Vector3__ctor_m2638739322((&V_0), L_4, L_9, (0.0f), /*hidden argument*/NULL);
		GameObject_t1756533147 * L_10 = __this->get_enemy_2();
		Vector3_t2243707580  L_11 = V_0;
		Quaternion_t4030073918  L_12 = Quaternion_get_identity_m1561886418(NULL /*static, unused*/, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_Instantiate_TisGameObject_t1756533147_m3064851704(NULL /*static, unused*/, L_10, L_11, L_12, /*hidden argument*/Object_Instantiate_TisGameObject_t1756533147_m3064851704_MethodInfo_var);
		return;
	}
}
// System.Void EnemyController::Update()
extern "C"  void EnemyController_Update_m3131616442 (EnemyController_t2146768720 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void enemyScript::.ctor()
extern "C"  void enemyScript__ctor_m2463363530 (enemyScript_t3437882687 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void enemyScript::Start()
extern Il2CppCodeGenString* _stringLiteral1414245993;
extern const uint32_t enemyScript_Start_m2404493894_MetadataUsageId;
extern "C"  void enemyScript_Start_m2404493894 (enemyScript_t3437882687 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (enemyScript_Start_m2404493894_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		MonoBehaviour_StartCoroutine_m1399371129(__this, _stringLiteral1414245993, /*hidden argument*/NULL);
		return;
	}
}
// System.Void enemyScript::Update()
extern "C"  void enemyScript_Update_m1158571743 (enemyScript_t3437882687 * __this, const MethodInfo* method)
{
	{
		Transform_t3275118058 * L_0 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Vector3_t2243707580  L_1 = Vector3_get_forward_m1201659139(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t2243707580  L_2 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_1, (3.0f), /*hidden argument*/NULL);
		float L_3 = Time_get_deltaTime_m2233168104(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t2243707580  L_4 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_2, L_3, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_Translate_m3316827744(L_0, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Collections.IEnumerator enemyScript::Move()
extern Il2CppClass* U3CMoveU3Ec__Iterator0_t3321662626_il2cpp_TypeInfo_var;
extern const uint32_t enemyScript_Move_m3850105209_MetadataUsageId;
extern "C"  Il2CppObject * enemyScript_Move_m3850105209 (enemyScript_t3437882687 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (enemyScript_Move_m3850105209_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	U3CMoveU3Ec__Iterator0_t3321662626 * V_0 = NULL;
	{
		U3CMoveU3Ec__Iterator0_t3321662626 * L_0 = (U3CMoveU3Ec__Iterator0_t3321662626 *)il2cpp_codegen_object_new(U3CMoveU3Ec__Iterator0_t3321662626_il2cpp_TypeInfo_var);
		U3CMoveU3Ec__Iterator0__ctor_m1455873023(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CMoveU3Ec__Iterator0_t3321662626 * L_1 = V_0;
		NullCheck(L_1);
		L_1->set_U24this_0(__this);
		U3CMoveU3Ec__Iterator0_t3321662626 * L_2 = V_0;
		return L_2;
	}
}
// System.Void enemyScript/<Move>c__Iterator0::.ctor()
extern "C"  void U3CMoveU3Ec__Iterator0__ctor_m1455873023 (U3CMoveU3Ec__Iterator0_t3321662626 * __this, const MethodInfo* method)
{
	{
		Object__ctor_m2551263788(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean enemyScript/<Move>c__Iterator0::MoveNext()
extern Il2CppClass* WaitForSeconds_t3839502067_il2cpp_TypeInfo_var;
extern const uint32_t U3CMoveU3Ec__Iterator0_MoveNext_m3895528477_MetadataUsageId;
extern "C"  bool U3CMoveU3Ec__Iterator0_MoveNext_m3895528477 (U3CMoveU3Ec__Iterator0_t3321662626 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CMoveU3Ec__Iterator0_MoveNext_m3895528477_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	uint32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_U24PC_3();
		V_0 = L_0;
		__this->set_U24PC_3((-1));
		uint32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_0021;
		}
		if (L_1 == 1)
		{
			goto IL_0045;
		}
	}
	{
		goto IL_0080;
	}

IL_0021:
	{
		WaitForSeconds_t3839502067 * L_2 = (WaitForSeconds_t3839502067 *)il2cpp_codegen_object_new(WaitForSeconds_t3839502067_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_m1990515539(L_2, (3.5f), /*hidden argument*/NULL);
		__this->set_U24current_1(L_2);
		bool L_3 = __this->get_U24disposing_2();
		if (L_3)
		{
			goto IL_0040;
		}
	}
	{
		__this->set_U24PC_3(1);
	}

IL_0040:
	{
		goto IL_0082;
	}

IL_0045:
	{
		enemyScript_t3437882687 * L_4 = __this->get_U24this_0();
		NullCheck(L_4);
		Transform_t3275118058 * L_5 = Component_get_transform_m2697483695(L_4, /*hidden argument*/NULL);
		Transform_t3275118058 * L_6 = L_5;
		NullCheck(L_6);
		Vector3_t2243707580  L_7 = Transform_get_eulerAngles_m4066505159(L_6, /*hidden argument*/NULL);
		Vector3_t2243707580  L_8;
		memset(&L_8, 0, sizeof(L_8));
		Vector3__ctor_m2638739322(&L_8, (0.0f), (180.0f), (0.0f), /*hidden argument*/NULL);
		Vector3_t2243707580  L_9 = Vector3_op_Addition_m3146764857(NULL /*static, unused*/, L_7, L_8, /*hidden argument*/NULL);
		NullCheck(L_6);
		Transform_set_eulerAngles_m2881310872(L_6, L_9, /*hidden argument*/NULL);
		goto IL_0021;
	}
	// Dead block : IL_0079: ldarg.0

IL_0080:
	{
		return (bool)0;
	}

IL_0082:
	{
		return (bool)1;
	}
}
// System.Object enemyScript/<Move>c__Iterator0::System.Collections.Generic.IEnumerator<object>.get_Current()
extern "C"  Il2CppObject * U3CMoveU3Ec__Iterator0_System_Collections_Generic_IEnumeratorU3CobjectU3E_get_Current_m3917796969 (U3CMoveU3Ec__Iterator0_t3321662626 * __this, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = __this->get_U24current_1();
		return L_0;
	}
}
// System.Object enemyScript/<Move>c__Iterator0::System.Collections.IEnumerator.get_Current()
extern "C"  Il2CppObject * U3CMoveU3Ec__Iterator0_System_Collections_IEnumerator_get_Current_m447391777 (U3CMoveU3Ec__Iterator0_t3321662626 * __this, const MethodInfo* method)
{
	{
		Il2CppObject * L_0 = __this->get_U24current_1();
		return L_0;
	}
}
// System.Void enemyScript/<Move>c__Iterator0::Dispose()
extern "C"  void U3CMoveU3Ec__Iterator0_Dispose_m3876759080 (U3CMoveU3Ec__Iterator0_t3321662626 * __this, const MethodInfo* method)
{
	{
		__this->set_U24disposing_2((bool)1);
		__this->set_U24PC_3((-1));
		return;
	}
}
// System.Void enemyScript/<Move>c__Iterator0::Reset()
extern Il2CppClass* NotSupportedException_t1793819818_il2cpp_TypeInfo_var;
extern const uint32_t U3CMoveU3Ec__Iterator0_Reset_m1641437150_MetadataUsageId;
extern "C"  void U3CMoveU3Ec__Iterator0_Reset_m1641437150 (U3CMoveU3Ec__Iterator0_t3321662626 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CMoveU3Ec__Iterator0_Reset_m1641437150_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		NotSupportedException_t1793819818 * L_0 = (NotSupportedException_t1793819818 *)il2cpp_codegen_object_new(NotSupportedException_t1793819818_il2cpp_TypeInfo_var);
		NotSupportedException__ctor_m3232764727(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0);
	}
}
// System.Void GameStatus::.ctor()
extern "C"  void GameStatus__ctor_m4136700137 (GameStatus_t1708871372 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// GameStatus GameStatus::GetInstance()
extern Il2CppClass* GameStatus_t1708871372_il2cpp_TypeInfo_var;
extern const uint32_t GameStatus_GetInstance_m42843623_MetadataUsageId;
extern "C"  GameStatus_t1708871372 * GameStatus_GetInstance_m42843623 (Il2CppObject * __this /* static, unused */, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (GameStatus_GetInstance_m42843623_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		GameStatus_t1708871372 * L_0 = ((GameStatus_t1708871372_StaticFields*)GameStatus_t1708871372_il2cpp_TypeInfo_var->static_fields)->get_instance_2();
		return L_0;
	}
}
// System.Void GameStatus::Start()
extern Il2CppClass* GameStatus_t1708871372_il2cpp_TypeInfo_var;
extern Il2CppClass* Object_t1021602117_il2cpp_TypeInfo_var;
extern const uint32_t GameStatus_Start_m2478266905_MetadataUsageId;
extern "C"  void GameStatus_Start_m2478266905 (GameStatus_t1708871372 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (GameStatus_Start_m2478266905_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		((GameStatus_t1708871372_StaticFields*)GameStatus_t1708871372_il2cpp_TypeInfo_var->static_fields)->set_instance_2(__this);
		GameObject_t1756533147 * L_0 = Component_get_gameObject_m3105766835(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_DontDestroyOnLoad_m2330762974(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		GameStatus_t1708871372 * L_1 = ((GameStatus_t1708871372_StaticFields*)GameStatus_t1708871372_il2cpp_TypeInfo_var->static_fields)->get_instance_2();
		bool L_2 = Object_op_Inequality_m2402264703(NULL /*static, unused*/, L_1, (Object_t1021602117 *)NULL, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_002d;
		}
	}
	{
		GameObject_t1756533147 * L_3 = Component_get_gameObject_m3105766835(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_Destroy_m4145850038(NULL /*static, unused*/, L_3, /*hidden argument*/NULL);
		return;
	}

IL_002d:
	{
		return;
	}
}
// System.Void GameStatus::OnDestroy()
extern Il2CppClass* Debug_t1368543263_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral1499554398;
extern const uint32_t GameStatus_OnDestroy_m3177230810_MetadataUsageId;
extern "C"  void GameStatus_OnDestroy_m3177230810 (GameStatus_t1708871372 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (GameStatus_OnDestroy_m3177230810_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t1368543263_il2cpp_TypeInfo_var);
		Debug_Log_m920475918(NULL /*static, unused*/, _stringLiteral1499554398, /*hidden argument*/NULL);
		return;
	}
}
// System.Void GameStatus::LoadScene(System.String)
extern "C"  void GameStatus_LoadScene_m3871531063 (GameStatus_t1708871372 * __this, String_t* ___sceneName0, const MethodInfo* method)
{
	{
		String_t* L_0 = ___sceneName0;
		SceneManager_LoadScene_m1619949821(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MainGamePanel::.ctor()
extern "C"  void MainGamePanel__ctor_m1461127766 (MainGamePanel_t3849144277 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MainGamePanel::Start()
extern "C"  void MainGamePanel_Start_m334188230 (MainGamePanel_t3849144277 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void MainGamePanel::Update()
extern "C"  void MainGamePanel_Update_m2507110305 (MainGamePanel_t3849144277 * __this, const MethodInfo* method)
{
	{
		MainGamePanel_PanelStateChanger_m1016541249(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MainGamePanel::SetPanelState(System.Int32)
extern Il2CppClass* Panel_t1787746694_il2cpp_TypeInfo_var;
extern const uint32_t MainGamePanel_SetPanelState_m1231443496_MetadataUsageId;
extern "C"  void MainGamePanel_SetPanelState_m1231443496 (MainGamePanel_t3849144277 * __this, int32_t ___tabNo0, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MainGamePanel_SetPanelState_m1231443496_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___tabNo0;
		if (L_0 == 0)
		{
			goto IL_001b;
		}
		if (L_0 == 1)
		{
			goto IL_0026;
		}
		if (L_0 == 2)
		{
			goto IL_0031;
		}
		if (L_0 == 3)
		{
			goto IL_003c;
		}
	}
	{
		goto IL_0047;
	}

IL_001b:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_gamePanel_1(0);
		goto IL_0047;
	}

IL_0026:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_gamePanel_1(1);
		goto IL_0047;
	}

IL_0031:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_gamePanel_1(2);
		goto IL_0047;
	}

IL_003c:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_gamePanel_1(3);
		goto IL_0047;
	}

IL_0047:
	{
		return;
	}
}
// System.Void MainGamePanel::PanelStateChanger()
extern Il2CppClass* Panel_t1787746694_il2cpp_TypeInfo_var;
extern const uint32_t MainGamePanel_PanelStateChanger_m1016541249_MetadataUsageId;
extern "C"  void MainGamePanel_PanelStateChanger_m1016541249 (MainGamePanel_t3849144277 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MainGamePanel_PanelStateChanger_m1016541249_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		int32_t L_0 = ((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->get_gamePanel_1();
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_0021;
		}
		if (L_1 == 1)
		{
			goto IL_005e;
		}
		if (L_1 == 2)
		{
			goto IL_009b;
		}
		if (L_1 == 3)
		{
			goto IL_00d8;
		}
	}
	{
		goto IL_0115;
	}

IL_0021:
	{
		GameObjectU5BU5D_t3057952154* L_2 = __this->get_panel_2();
		NullCheck(L_2);
		int32_t L_3 = 0;
		GameObject_t1756533147 * L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		NullCheck(L_4);
		GameObject_SetActive_m2887581199(L_4, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_5 = __this->get_panel_2();
		NullCheck(L_5);
		int32_t L_6 = 1;
		GameObject_t1756533147 * L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		NullCheck(L_7);
		GameObject_SetActive_m2887581199(L_7, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_8 = __this->get_panel_2();
		NullCheck(L_8);
		int32_t L_9 = 2;
		GameObject_t1756533147 * L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		NullCheck(L_10);
		GameObject_SetActive_m2887581199(L_10, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_11 = __this->get_panel_2();
		NullCheck(L_11);
		int32_t L_12 = 3;
		GameObject_t1756533147 * L_13 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		NullCheck(L_13);
		GameObject_SetActive_m2887581199(L_13, (bool)0, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_005e:
	{
		GameObjectU5BU5D_t3057952154* L_14 = __this->get_panel_2();
		NullCheck(L_14);
		int32_t L_15 = 0;
		GameObject_t1756533147 * L_16 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		NullCheck(L_16);
		GameObject_SetActive_m2887581199(L_16, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_17 = __this->get_panel_2();
		NullCheck(L_17);
		int32_t L_18 = 1;
		GameObject_t1756533147 * L_19 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		NullCheck(L_19);
		GameObject_SetActive_m2887581199(L_19, (bool)1, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_20 = __this->get_panel_2();
		NullCheck(L_20);
		int32_t L_21 = 2;
		GameObject_t1756533147 * L_22 = (L_20)->GetAt(static_cast<il2cpp_array_size_t>(L_21));
		NullCheck(L_22);
		GameObject_SetActive_m2887581199(L_22, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_23 = __this->get_panel_2();
		NullCheck(L_23);
		int32_t L_24 = 3;
		GameObject_t1756533147 * L_25 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		NullCheck(L_25);
		GameObject_SetActive_m2887581199(L_25, (bool)0, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_009b:
	{
		GameObjectU5BU5D_t3057952154* L_26 = __this->get_panel_2();
		NullCheck(L_26);
		int32_t L_27 = 0;
		GameObject_t1756533147 * L_28 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		NullCheck(L_28);
		GameObject_SetActive_m2887581199(L_28, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_29 = __this->get_panel_2();
		NullCheck(L_29);
		int32_t L_30 = 1;
		GameObject_t1756533147 * L_31 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		NullCheck(L_31);
		GameObject_SetActive_m2887581199(L_31, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_32 = __this->get_panel_2();
		NullCheck(L_32);
		int32_t L_33 = 2;
		GameObject_t1756533147 * L_34 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		NullCheck(L_34);
		GameObject_SetActive_m2887581199(L_34, (bool)1, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_35 = __this->get_panel_2();
		NullCheck(L_35);
		int32_t L_36 = 3;
		GameObject_t1756533147 * L_37 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		NullCheck(L_37);
		GameObject_SetActive_m2887581199(L_37, (bool)0, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_00d8:
	{
		GameObjectU5BU5D_t3057952154* L_38 = __this->get_panel_2();
		NullCheck(L_38);
		int32_t L_39 = 0;
		GameObject_t1756533147 * L_40 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		NullCheck(L_40);
		GameObject_SetActive_m2887581199(L_40, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_41 = __this->get_panel_2();
		NullCheck(L_41);
		int32_t L_42 = 1;
		GameObject_t1756533147 * L_43 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		NullCheck(L_43);
		GameObject_SetActive_m2887581199(L_43, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_44 = __this->get_panel_2();
		NullCheck(L_44);
		int32_t L_45 = 2;
		GameObject_t1756533147 * L_46 = (L_44)->GetAt(static_cast<il2cpp_array_size_t>(L_45));
		NullCheck(L_46);
		GameObject_SetActive_m2887581199(L_46, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_47 = __this->get_panel_2();
		NullCheck(L_47);
		int32_t L_48 = 3;
		GameObject_t1756533147 * L_49 = (L_47)->GetAt(static_cast<il2cpp_array_size_t>(L_48));
		NullCheck(L_49);
		GameObject_SetActive_m2887581199(L_49, (bool)1, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_0115:
	{
		return;
	}
}
// System.Void Panel::.cctor()
extern "C"  void Panel__cctor_m3143452184 (Il2CppObject * __this /* static, unused */, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void PanelState::.ctor()
extern "C"  void PanelState__ctor_m1448892942 (PanelState_t3008758799 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void PanelState::Start()
extern "C"  void PanelState_Start_m1560533434 (PanelState_t3008758799 * __this, const MethodInfo* method)
{
	{
		return;
	}
}
// System.Void PanelState::Update()
extern "C"  void PanelState_Update_m885714199 (PanelState_t3008758799 * __this, const MethodInfo* method)
{
	{
		PanelState_PanelStateChanger_m3355645503(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void PanelState::SetPanelState(System.Int32)
extern Il2CppClass* Panel_t1787746694_il2cpp_TypeInfo_var;
extern const uint32_t PanelState_SetPanelState_m2531292388_MetadataUsageId;
extern "C"  void PanelState_SetPanelState_m2531292388 (PanelState_t3008758799 * __this, int32_t ___tabNo0, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (PanelState_SetPanelState_m2531292388_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___tabNo0;
		if (L_0 == 0)
		{
			goto IL_001b;
		}
		if (L_0 == 1)
		{
			goto IL_0026;
		}
		if (L_0 == 2)
		{
			goto IL_0031;
		}
		if (L_0 == 3)
		{
			goto IL_003c;
		}
	}
	{
		goto IL_0047;
	}

IL_001b:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_titlePanel_0(0);
		goto IL_0047;
	}

IL_0026:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_titlePanel_0(1);
		goto IL_0047;
	}

IL_0031:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_titlePanel_0(2);
		goto IL_0047;
	}

IL_003c:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->set_titlePanel_0(3);
		goto IL_0047;
	}

IL_0047:
	{
		return;
	}
}
// System.Void PanelState::PanelStateChanger()
extern Il2CppClass* Panel_t1787746694_il2cpp_TypeInfo_var;
extern const uint32_t PanelState_PanelStateChanger_m3355645503_MetadataUsageId;
extern "C"  void PanelState_PanelStateChanger_m3355645503 (PanelState_t3008758799 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (PanelState_PanelStateChanger_m3355645503_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Panel_t1787746694_il2cpp_TypeInfo_var);
		int32_t L_0 = ((Panel_t1787746694_StaticFields*)Panel_t1787746694_il2cpp_TypeInfo_var->static_fields)->get_titlePanel_0();
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (L_1 == 0)
		{
			goto IL_0021;
		}
		if (L_1 == 1)
		{
			goto IL_005e;
		}
		if (L_1 == 2)
		{
			goto IL_009b;
		}
		if (L_1 == 3)
		{
			goto IL_00d8;
		}
	}
	{
		goto IL_0115;
	}

IL_0021:
	{
		GameObjectU5BU5D_t3057952154* L_2 = __this->get_panel_2();
		NullCheck(L_2);
		int32_t L_3 = 0;
		GameObject_t1756533147 * L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		NullCheck(L_4);
		GameObject_SetActive_m2887581199(L_4, (bool)1, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_5 = __this->get_panel_2();
		NullCheck(L_5);
		int32_t L_6 = 1;
		GameObject_t1756533147 * L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		NullCheck(L_7);
		GameObject_SetActive_m2887581199(L_7, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_8 = __this->get_panel_2();
		NullCheck(L_8);
		int32_t L_9 = 2;
		GameObject_t1756533147 * L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		NullCheck(L_10);
		GameObject_SetActive_m2887581199(L_10, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_11 = __this->get_panel_2();
		NullCheck(L_11);
		int32_t L_12 = 3;
		GameObject_t1756533147 * L_13 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		NullCheck(L_13);
		GameObject_SetActive_m2887581199(L_13, (bool)0, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_005e:
	{
		GameObjectU5BU5D_t3057952154* L_14 = __this->get_panel_2();
		NullCheck(L_14);
		int32_t L_15 = 0;
		GameObject_t1756533147 * L_16 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		NullCheck(L_16);
		GameObject_SetActive_m2887581199(L_16, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_17 = __this->get_panel_2();
		NullCheck(L_17);
		int32_t L_18 = 1;
		GameObject_t1756533147 * L_19 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		NullCheck(L_19);
		GameObject_SetActive_m2887581199(L_19, (bool)1, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_20 = __this->get_panel_2();
		NullCheck(L_20);
		int32_t L_21 = 2;
		GameObject_t1756533147 * L_22 = (L_20)->GetAt(static_cast<il2cpp_array_size_t>(L_21));
		NullCheck(L_22);
		GameObject_SetActive_m2887581199(L_22, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_23 = __this->get_panel_2();
		NullCheck(L_23);
		int32_t L_24 = 3;
		GameObject_t1756533147 * L_25 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		NullCheck(L_25);
		GameObject_SetActive_m2887581199(L_25, (bool)0, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_009b:
	{
		GameObjectU5BU5D_t3057952154* L_26 = __this->get_panel_2();
		NullCheck(L_26);
		int32_t L_27 = 0;
		GameObject_t1756533147 * L_28 = (L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		NullCheck(L_28);
		GameObject_SetActive_m2887581199(L_28, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_29 = __this->get_panel_2();
		NullCheck(L_29);
		int32_t L_30 = 1;
		GameObject_t1756533147 * L_31 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		NullCheck(L_31);
		GameObject_SetActive_m2887581199(L_31, (bool)1, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_32 = __this->get_panel_2();
		NullCheck(L_32);
		int32_t L_33 = 2;
		GameObject_t1756533147 * L_34 = (L_32)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		NullCheck(L_34);
		GameObject_SetActive_m2887581199(L_34, (bool)1, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_35 = __this->get_panel_2();
		NullCheck(L_35);
		int32_t L_36 = 3;
		GameObject_t1756533147 * L_37 = (L_35)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		NullCheck(L_37);
		GameObject_SetActive_m2887581199(L_37, (bool)0, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_00d8:
	{
		GameObjectU5BU5D_t3057952154* L_38 = __this->get_panel_2();
		NullCheck(L_38);
		int32_t L_39 = 0;
		GameObject_t1756533147 * L_40 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		NullCheck(L_40);
		GameObject_SetActive_m2887581199(L_40, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_41 = __this->get_panel_2();
		NullCheck(L_41);
		int32_t L_42 = 1;
		GameObject_t1756533147 * L_43 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		NullCheck(L_43);
		GameObject_SetActive_m2887581199(L_43, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_44 = __this->get_panel_2();
		NullCheck(L_44);
		int32_t L_45 = 2;
		GameObject_t1756533147 * L_46 = (L_44)->GetAt(static_cast<il2cpp_array_size_t>(L_45));
		NullCheck(L_46);
		GameObject_SetActive_m2887581199(L_46, (bool)0, /*hidden argument*/NULL);
		GameObjectU5BU5D_t3057952154* L_47 = __this->get_panel_2();
		NullCheck(L_47);
		int32_t L_48 = 3;
		GameObject_t1756533147 * L_49 = (L_47)->GetAt(static_cast<il2cpp_array_size_t>(L_48));
		NullCheck(L_49);
		GameObject_SetActive_m2887581199(L_49, (bool)1, /*hidden argument*/NULL);
		goto IL_0115;
	}

IL_0115:
	{
		return;
	}
}
// System.Void webCamScript::.ctor()
extern "C"  void webCamScript__ctor_m2242918439 (webCamScript_t1312139898 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2464341955(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void webCamScript::Start()
extern Il2CppClass* GameObject_t1756533147_il2cpp_TypeInfo_var;
extern Il2CppClass* Input_t1785128008_il2cpp_TypeInfo_var;
extern Il2CppClass* UnityAction_t4025899511_il2cpp_TypeInfo_var;
extern Il2CppClass* WebCamTexture_t1079476942_il2cpp_TypeInfo_var;
extern const MethodInfo* webCamScript_OnButtonDown_m3845591788_MethodInfo_var;
extern const MethodInfo* GameObject_GetComponent_TisMeshRenderer_t1268241104_m3528968632_MethodInfo_var;
extern Il2CppCodeGenString* _stringLiteral3752213123;
extern const uint32_t webCamScript_Start_m3436594843_MetadataUsageId;
extern "C"  void webCamScript_Start_m3436594843 (webCamScript_t1312139898 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (webCamScript_Start_m3436594843_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_t1756533147 * V_0 = NULL;
	WebCamTexture_t1079476942 * V_1 = NULL;
	{
		bool L_0 = Application_get_isMobilePlatform_m1067527467(NULL /*static, unused*/, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0051;
		}
	}
	{
		GameObject_t1756533147 * L_1 = (GameObject_t1756533147 *)il2cpp_codegen_object_new(GameObject_t1756533147_il2cpp_TypeInfo_var);
		GameObject__ctor_m962601984(L_1, _stringLiteral3752213123, /*hidden argument*/NULL);
		V_0 = L_1;
		GameObject_t1756533147 * L_2 = V_0;
		NullCheck(L_2);
		Transform_t3275118058 * L_3 = GameObject_get_transform_m909382139(L_2, /*hidden argument*/NULL);
		Transform_t3275118058 * L_4 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		Vector3_t2243707580  L_5 = Transform_get_position_m1104419803(L_4, /*hidden argument*/NULL);
		NullCheck(L_3);
		Transform_set_position_m2469242620(L_3, L_5, /*hidden argument*/NULL);
		Transform_t3275118058 * L_6 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		GameObject_t1756533147 * L_7 = V_0;
		NullCheck(L_7);
		Transform_t3275118058 * L_8 = GameObject_get_transform_m909382139(L_7, /*hidden argument*/NULL);
		NullCheck(L_6);
		Transform_set_parent_m3281327839(L_6, L_8, /*hidden argument*/NULL);
		GameObject_t1756533147 * L_9 = V_0;
		NullCheck(L_9);
		Transform_t3275118058 * L_10 = GameObject_get_transform_m909382139(L_9, /*hidden argument*/NULL);
		Vector3_t2243707580  L_11 = Vector3_get_right_m1884123822(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_10);
		Transform_Rotate_m882843932(L_10, L_11, (90.0f), /*hidden argument*/NULL);
	}

IL_0051:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		Gyroscope_t1705362817 * L_12 = Input_get_gyro_m4027090408(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_12);
		Gyroscope_set_enabled_m487023127(L_12, (bool)1, /*hidden argument*/NULL);
		Button_t2872111280 * L_13 = __this->get_fireButton_3();
		NullCheck(L_13);
		ButtonClickedEvent_t2455055323 * L_14 = Button_get_onClick_m1595880935(L_13, /*hidden argument*/NULL);
		IntPtr_t L_15;
		L_15.set_m_value_0((void*)(void*)webCamScript_OnButtonDown_m3845591788_MethodInfo_var);
		UnityAction_t4025899511 * L_16 = (UnityAction_t4025899511 *)il2cpp_codegen_object_new(UnityAction_t4025899511_il2cpp_TypeInfo_var);
		UnityAction__ctor_m2649891629(L_16, __this, L_15, /*hidden argument*/NULL);
		NullCheck(L_14);
		UnityEvent_AddListener_m1596810379(L_14, L_16, /*hidden argument*/NULL);
		WebCamTexture_t1079476942 * L_17 = (WebCamTexture_t1079476942 *)il2cpp_codegen_object_new(WebCamTexture_t1079476942_il2cpp_TypeInfo_var);
		WebCamTexture__ctor_m1125343005(L_17, /*hidden argument*/NULL);
		V_1 = L_17;
		GameObject_t1756533147 * L_18 = __this->get_webCameraPlane_2();
		NullCheck(L_18);
		MeshRenderer_t1268241104 * L_19 = GameObject_GetComponent_TisMeshRenderer_t1268241104_m3528968632(L_18, /*hidden argument*/GameObject_GetComponent_TisMeshRenderer_t1268241104_m3528968632_MethodInfo_var);
		NullCheck(L_19);
		Material_t193706927 * L_20 = Renderer_get_material_m2553789785(L_19, /*hidden argument*/NULL);
		WebCamTexture_t1079476942 * L_21 = V_1;
		NullCheck(L_20);
		Material_set_mainTexture_m3584203343(L_20, L_21, /*hidden argument*/NULL);
		WebCamTexture_t1079476942 * L_22 = V_1;
		NullCheck(L_22);
		WebCamTexture_Play_m1997372813(L_22, /*hidden argument*/NULL);
		return;
	}
}
// System.Void webCamScript::OnButtonDown()
extern const Il2CppType* GameObject_t1756533147_0_0_0_var;
extern Il2CppClass* Type_t_il2cpp_TypeInfo_var;
extern Il2CppClass* Object_t1021602117_il2cpp_TypeInfo_var;
extern Il2CppClass* GameObject_t1756533147_il2cpp_TypeInfo_var;
extern const MethodInfo* GameObject_GetComponent_TisRigidbody_t4233889191_m1060888193_MethodInfo_var;
extern const MethodInfo* Component_GetComponent_TisAudioSource_t1135106623_m3920278003_MethodInfo_var;
extern Il2CppCodeGenString* _stringLiteral3318161334;
extern const uint32_t webCamScript_OnButtonDown_m3845591788_MetadataUsageId;
extern "C"  void webCamScript_OnButtonDown_m3845591788 (webCamScript_t1312139898 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (webCamScript_OnButtonDown_m3845591788_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_t1756533147 * V_0 = NULL;
	Rigidbody_t4233889191 * V_1 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_0 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(GameObject_t1756533147_0_0_0_var), /*hidden argument*/NULL);
		Object_t1021602117 * L_1 = Resources_Load_m243305716(NULL /*static, unused*/, _stringLiteral3318161334, L_0, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_t1021602117 * L_2 = Object_Instantiate_m2439155489(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
		V_0 = ((GameObject_t1756533147 *)IsInstSealed(L_2, GameObject_t1756533147_il2cpp_TypeInfo_var));
		GameObject_t1756533147 * L_3 = V_0;
		NullCheck(L_3);
		Rigidbody_t4233889191 * L_4 = GameObject_GetComponent_TisRigidbody_t4233889191_m1060888193(L_3, /*hidden argument*/GameObject_GetComponent_TisRigidbody_t4233889191_m1060888193_MethodInfo_var);
		V_1 = L_4;
		GameObject_t1756533147 * L_5 = V_0;
		NullCheck(L_5);
		Transform_t3275118058 * L_6 = GameObject_get_transform_m909382139(L_5, /*hidden argument*/NULL);
		Camera_t189460977 * L_7 = Camera_get_main_m475173995(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_7);
		Transform_t3275118058 * L_8 = Component_get_transform_m2697483695(L_7, /*hidden argument*/NULL);
		NullCheck(L_8);
		Quaternion_t4030073918  L_9 = Transform_get_rotation_m1033555130(L_8, /*hidden argument*/NULL);
		NullCheck(L_6);
		Transform_set_rotation_m3411284563(L_6, L_9, /*hidden argument*/NULL);
		GameObject_t1756533147 * L_10 = V_0;
		NullCheck(L_10);
		Transform_t3275118058 * L_11 = GameObject_get_transform_m909382139(L_10, /*hidden argument*/NULL);
		Camera_t189460977 * L_12 = Camera_get_main_m475173995(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_12);
		Transform_t3275118058 * L_13 = Component_get_transform_m2697483695(L_12, /*hidden argument*/NULL);
		NullCheck(L_13);
		Vector3_t2243707580  L_14 = Transform_get_position_m1104419803(L_13, /*hidden argument*/NULL);
		Vector3_t2243707580  L_15 = __this->get_offset_4();
		Vector3_t2243707580  L_16 = Vector3_op_Addition_m3146764857(NULL /*static, unused*/, L_14, L_15, /*hidden argument*/NULL);
		NullCheck(L_11);
		Transform_set_position_m2469242620(L_11, L_16, /*hidden argument*/NULL);
		Rigidbody_t4233889191 * L_17 = V_1;
		Camera_t189460977 * L_18 = Camera_get_main_m475173995(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_18);
		Transform_t3275118058 * L_19 = Component_get_transform_m2697483695(L_18, /*hidden argument*/NULL);
		NullCheck(L_19);
		Vector3_t2243707580  L_20 = Transform_get_forward_m1833488937(L_19, /*hidden argument*/NULL);
		Vector3_t2243707580  L_21 = Vector3_op_Multiply_m1351554733(NULL /*static, unused*/, L_20, (500.0f), /*hidden argument*/NULL);
		NullCheck(L_17);
		Rigidbody_AddForce_m2836187433(L_17, L_21, /*hidden argument*/NULL);
		GameObject_t1756533147 * L_22 = V_0;
		Object_Destroy_m4279412553(NULL /*static, unused*/, L_22, (3.0f), /*hidden argument*/NULL);
		AudioSource_t1135106623 * L_23 = Component_GetComponent_TisAudioSource_t1135106623_m3920278003(__this, /*hidden argument*/Component_GetComponent_TisAudioSource_t1135106623_m3920278003_MethodInfo_var);
		NullCheck(L_23);
		AudioSource_Play_m353744792(L_23, /*hidden argument*/NULL);
		return;
	}
}
// System.Void webCamScript::Update()
extern Il2CppClass* Input_t1785128008_il2cpp_TypeInfo_var;
extern const uint32_t webCamScript_Update_m3624635880_MetadataUsageId;
extern "C"  void webCamScript_Update_m3624635880 (webCamScript_t1312139898 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (webCamScript_Update_m3624635880_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Quaternion_t4030073918  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Quaternion_t4030073918  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Quaternion_t4030073918  V_2;
	memset(&V_2, 0, sizeof(V_2));
	Quaternion_t4030073918  V_3;
	memset(&V_3, 0, sizeof(V_3));
	Quaternion_t4030073918  V_4;
	memset(&V_4, 0, sizeof(V_4));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		Gyroscope_t1705362817 * L_0 = Input_get_gyro_m4027090408(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_0);
		Quaternion_t4030073918  L_1 = Gyroscope_get_attitude_m3665233473(L_0, /*hidden argument*/NULL);
		V_1 = L_1;
		float L_2 = (&V_1)->get_x_0();
		Gyroscope_t1705362817 * L_3 = Input_get_gyro_m4027090408(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_3);
		Quaternion_t4030073918  L_4 = Gyroscope_get_attitude_m3665233473(L_3, /*hidden argument*/NULL);
		V_2 = L_4;
		float L_5 = (&V_2)->get_y_1();
		Gyroscope_t1705362817 * L_6 = Input_get_gyro_m4027090408(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_6);
		Quaternion_t4030073918  L_7 = Gyroscope_get_attitude_m3665233473(L_6, /*hidden argument*/NULL);
		V_3 = L_7;
		float L_8 = (&V_3)->get_z_2();
		Gyroscope_t1705362817 * L_9 = Input_get_gyro_m4027090408(NULL /*static, unused*/, /*hidden argument*/NULL);
		NullCheck(L_9);
		Quaternion_t4030073918  L_10 = Gyroscope_get_attitude_m3665233473(L_9, /*hidden argument*/NULL);
		V_4 = L_10;
		float L_11 = (&V_4)->get_w_3();
		Quaternion__ctor_m3196903881((&V_0), L_2, L_5, ((-L_8)), ((-L_11)), /*hidden argument*/NULL);
		Transform_t3275118058 * L_12 = Component_get_transform_m2697483695(__this, /*hidden argument*/NULL);
		Quaternion_t4030073918  L_13 = V_0;
		NullCheck(L_12);
		Transform_set_localRotation_m2055111962(L_12, L_13, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
