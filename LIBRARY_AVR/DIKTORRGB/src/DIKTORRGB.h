#ifndef _DIKTORRGB_h
#define _DIKTORRGB_h
#include <inttypes.h>
#include <Arduino.h>

class DIKTORRGB {
public:

	DIKTORRGB(byte _R1Pin, byte _G1Pin, byte _B1Pin, byte _R2Pin = -1, byte _G2Pin = -1, byte _B2Pin = -1); // 2х канал
	void SetCtrMode(bool _CrtUse);
	bool GetCrTuSE();
	void SetMaxBrightness(int _max_brightness);

	//--------
	void OnAnimation();
	void StopAnimation();
	void SwitchAnimation(int);
	void DisableLight(bool);
	void DisableAll();
	bool IsAnimNumber(int);
	
	//---SET (1)
	void SetColor(int, int, int);
	void SetColorByNum(int _color, bool stop_anim = false);
	void SetRandomColor();

	//-----Full (2)
	void InitFullAnimation(int _DelayAnim, int _DelayColor);
	void OnFullAnimation();
	void StopFullAnimation();

	//----Fade (3)
	void InitFadeAnimation(int _DelayAnim, int _DelayColor);
	void OnFadeAnimation();
	void StopFadeAnimation();

	//----Random Color (8)
	void InitRCAnimation(int);
	void OnRCAnimation();
	void StopRCAnimation();


private:
	void _SetColor(int, int, int);
	byte R1_Pin = 0;
	byte G1_Pin = 0;
	byte B1_Pin = 0;

	byte R2_Pin = -1;
	byte G2_Pin = -1;
	byte B2_Pin = -1;

	bool IsDoubleChannel = false;
	bool IsUseCRT = true;
	unsigned long last_millis = 0;
	int anim_num = 0; // disable, 1 setted color, 2 full, 2 fade, 3 full offset dual, 4 fade offset dual, 5 6color smooth, 7 3colorsmooth, 8 random color // max 8
	int anim_mode = 0;  // 0 start(red), 1 yellow loop, 2 green loop, 3 blue loop, 4 blue loop, 5 purple loop, 6 red loop


	int DelayAnim = 0;
	int DelayColor = 0;
	int MaxBrightness = 0;
	int CurrDelay = 0;
	//byte A1mode = 0;
	int colorStep = 0;

	//---MODE 2 add vars // full
	bool startM2 = false;
	//---MODE 8 add vars random colors
	byte last_color = 0; // disabled
};

byte getBrightCRT(byte val);
int _RandVUKL(int min, int max, bool set_seed = true);
int _RandVKL(int min, int max, bool set_seed = true);

#endif