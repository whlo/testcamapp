using System;
using System.Runtime.InteropServices;

public enum CaioConst
{
	// �O������M��
	AIO_AIF_CLOCK						= 0,			//�A�i���O���͊O���N���b�N
	AIO_AIF_START						= 1,			//�A�i���O���͊O���J�n�g���K
	AIO_AIF_STOP						= 2,			//�A�i���O���͊O����~�g���K
	AIO_AOF_CLOCK						= 3,			//�A�i���O�o�͊O���N���b�N
	AIO_AOF_START						= 4,			//�A�i���O�o�͊O���J�n�g���K
	AIO_AOF_STOP						= 5,			//�A�i���O�o�͊O����~�g���K

	// ���o�̓����W
	PM10								= 0,			//�}10V
	PM5									= 1,			//�}5V
	PM25								= 2,			//�}2.5V
	PM125								= 3,			//�}1.25V
	PM1									= 4,			//�}1V
	PM0625								= 5,			//�}0.625V
	PM05								= 6,			//�}0.5V
	PM03125								= 7,			//�}0.3125V
	PM025								= 8,			//�}0.25V
	PM0125								= 9,			//�}0.125V
	PM01								= 10,			//�}0.1V
	PM005								= 11,			//�}0.05V
	PM0025								= 12,			//�}0.025V
	PM00125								= 13,			//�}0.0125V
	PM001								= 14,			//�}0.01V
	P10									= 50,			//0�`10V
	P5									= 51,			//0�`5V
	P4095								= 52,			//0�`4.095V
	P25									= 53,			//0�`2.5V
	P125								= 54,			//0�`1.25V
	P1									= 55,			//0�`1V
	P05									= 56,			//0�`0.5V
	P025								= 57,			//0�`0.25V
	P01									= 58,			//0�`0.1V
	P005								= 59,			//0�`0.05V
	P0025								= 60,			//0�`0.025V
	P00125								= 61,			//0�`0.0125V
	P001								= 62,			//0�`0.01V
	P20MA								= 100,			//0�`20mA
	P4TO20MA							= 101,			//4�`20mA
	P1TO5								= 150,			//1�`5V

	// �A�i���O���̓C�x���g
	AIE_START							= 0x00000002,	//AD�ϊ��J�n���������C�x���g
	AIE_RPTEND							= 0x00000010,	//���s�[�g�I���C�x���g
	AIE_END								= 0x00000020,	//�f�o�C�X����I���C�x���g
	AIE_DATA_NUM						= 0x00000080,	//�w��T���v�����O�񐔊i�[�C�x���g
	AIE_DATA_TSF						= 0x00000100,	//�w��]�������C�x���g
	AIE_OFERR							= 0x00010000,	//�I�[�o�[�t���[�C�x���g
	AIE_SCERR							= 0x00020000,	//�T���v�����O�N���b�N�G���[�C�x���g
	AIE_ADERR							= 0x00040000,	//AD�ϊ��G���[�C�x���g

	// �A�i���O�o�̓C�x���g
	AOE_START							= 0x00000002,	//DA�ϊ��J�n���������C�x���g
	AOE_RPTEND							= 0x00000010,	//���s�[�g�I���C�x���g
	AOE_END								= 0x00000020,	//�f�o�C�X����I���C�x���g
	AOE_DATA_NUM						= 0x00000080,	//�w��T���v�����O�񐔏o�̓C�x���g
	AOE_DATA_TSF						= 0x00000100,	//�w��]�������C�x���g
	AOE_SCERR							= 0x00020000,	//�T���v�����O�N���b�N�G���[�C�x���g
	AOE_DAERR							= 0x00040000,	//DA�ϊ��G���[�C�x���g

	// �J�E���^�C�x���g
	CNTE_DATA_NUM						= 0x00000010,	//��r�J�E���g��v�C�x���g
	CNTE_ORERR							= 0x00010000,	//�J�E���g�I�[�o�[�����C�x���g
	CNTE_ERR							= 0x00020000,	//�J�E���^����G���[

	// �^�C�}�C�x���g
	TME_INT								= 0x00000001,	//�C���^�[�o�������C�x���g

	// �A�i���O���̓X�e�[�^�X
	AIS_BUSY							= 0x00000001,	//�f�o�C�X���쒆
	AIS_START_TRG						= 0x00000002,	//�J�n�g���K�҂�
	AIS_DATA_NUM						= 0x00000010,	//�w��T���v�����O�񐔊i�[
	AIS_OFERR							= 0x00010000,	//�I�[�o�[�t���[
	AIS_SCERR							= 0x00020000,	//�T���v�����O�N���b�N�G���[
	AIS_AIERR							= 0x00040000,	//AD�ϊ��G���[
	AIS_DRVERR							= 0x00080000,	//�h���C�o�X�y�b�N�G���[

	// �A�i���O�o�̓X�e�[�^�X
	AOS_BUSY							= 0x00000001,	//�f�o�C�X���쒆
	AOS_START_TRG						= 0x00000002,	//�J�n�g���K�҂�
	AOS_DATA_NUM						= 0x00000010,	//�w��T���v�����O�񐔏o��
	AOS_SCERR							= 0x00020000,	//�T���v�����O�N���b�N�G���[
	AOS_AOERR							= 0x00040000,	//DA�ϊ��G���[
	AOS_DRVERR							= 0x00080000,	//�h���C�o�X�y�b�N�G���[

	// �J�E���^�X�e�[�^�X
	CNTS_BUSY							= 0x00000001,	//�J�E���^���쒆
	CNTS_DATA_NUM						= 0x00000010,	//��r�J�E���g��v
	CNTS_ORERR							= 0x00010000,	//�I�[�o�[����
	CNTS_ERR							= 0x00020000,	//�J�E���^����G���[

	// �A�i���O���̓��b�Z�[�W
	AIOM_AIE_START						= 0x1000,		//AD�ϊ��J�n���������C�x���g
	AIOM_AIE_RPTEND						= 0x1001,		//���s�[�g�I���C�x���g
	AIOM_AIE_END						= 0x1002,		//�f�o�C�X����I���C�x���g
	AIOM_AIE_DATA_NUM					= 0x1003,		//�w��T���v�����O�񐔊i�[�C�x���g
	AIOM_AIE_DATA_TSF					= 0x1007,		//�w��]�������C�x���g
	AIOM_AIE_OFERR						= 0x1004,		//�I�[�o�[�t���[�C�x���g
	AIOM_AIE_SCERR						= 0x1005,		//�T���v�����O�N���b�N�G���[�C�x���g
	AIOM_AIE_ADERR						= 0x1006,		//AD�ϊ��G���[�C�x���g

	// �A�i���O�o�̓��b�Z�[�W
	AIOM_AOE_START						= 0x1020,		//DA�ϊ��J�n���������C�x���g
	AIOM_AOE_RPTEND						= 0x1021,		//���s�[�g�I���C�x���g
	AIOM_AOE_END						= 0x1022,		//�f�o�C�X����I���C�x���g
	AIOM_AOE_DATA_NUM					= 0x1023,		//�w��T���v�����O�񐔏o�̓C�x���g
	AIOM_AOE_DATA_TSF					= 0x1027,		//�w��]�������C�x���g
	AIOM_AOE_SCERR						= 0x1025,		//�T���v�����O�N���b�N�G���[�C�x���g
	AIOM_AOE_DAERR						= 0x1026,		//DA�ϊ��G���[�C�x���g

	// �J�E���^���b�Z�[�W
	AIOM_CNTE_DATA_NUM					= 0x1042,		//��r�J�E���g��v�C�x���g
	AIOM_CNTE_ORERR						= 0x1043,		//�J�E���g�I�[�o�[�����C�x���g
	AIOM_CNTE_ERR						= 0x1044,		//�J�E���g����G���[�C�x���g

	// �^�C�}���b�Z�[�W
	AIOM_TME_INT						= 0x1060,		//�C���^�[�o�������C�x���g

	// M�f�o�C�X�p�J�E���^���b�Z�[�W
	AIOM_CNTM_COUNTUP_CH0				= 0x1070,		// �J�E���g�A�b�v�A�`���l���ԍ�0
	AIOM_CNTM_COUNTUP_CH1				= 0x1071,		//         "                   1

	AIOM_CNTM_TIME_UP					= 0x1090,		//�^�C���A�b�v
	AIOM_CNTM_COUNTER_ERROR				= 0x1091,		//�J�E���^�G���[
	AIOM_CNTM_CARRY_BORROW				= 0x1092,		//�L�����[�^�{���[

	// �A�i���O���͓Y�t�f�[�^
	AIAT_AI								= 0x00000001,	//�A�i���O���͕t�����
	AIAT_AO0							= 0x00000100,	//�A�i���O�o�̓f�[�^
	AIAT_DIO0							= 0x00010000,	//�f�W�^�����o�̓f�[�^
	AIAT_CNT0							= 0x01000000,	//�J�E���^�`���l���O�f�[�^
	AIAT_CNT1							= 0x02000000,	//�J�E���^�`���l���P�f�[�^

	// �J�E���^���샂�[�h
	CNT_LOADPRESET						= 0x0000001,	//�v���Z�b�g�J�E���g�l�̃��[�h
	CNT_LOADCOMP						= 0x0000002,	//��r�J�E���g�l�̃��[�h

	// �C�x���g�R���g���[���ڑ���M��
	AIOECU_DEST_AI_CLK					= 4,			//�A�i���O���̓T���v�����O�N���b�N
	AIOECU_DEST_AI_START				= 0,			//�A�i���O���͕ϊ��J�n�M��
	AIOECU_DEST_AI_STOP					= 2,			//�A�i���O���͕ϊ���~�M��
	AIOECU_DEST_AO_CLK					= 36,			//�A�i���O�o�̓T���v�����O�N���b�N
	AIOECU_DEST_AO_START				= 32,			//�A�i���O�o�͕ϊ��J�n�M��
	AIOECU_DEST_AO_STOP					= 34,			//�A�i���O�o�͕ϊ���~�M��
	AIOECU_DEST_CNT0_UPCLK				= 134,			//�J�E���^�O�A�b�v�N���b�N�M��
	AIOECU_DEST_CNT1_UPCLK				= 135,			//�J�E���^�P�A�b�v�N���b�N�M��
	AIOECU_DEST_CNT0_START				= 128,			//�J�E���^�O�A�^�C�}�O����J�n�M��
	AIOECU_DEST_CNT1_START				= 129,			//�J�E���^�P�A�^�C�}�P����J�n�M��
	AIOECU_DEST_CNT0_STOP				= 130,			//�J�E���^�O�A�^�C�}�O�����~�M��
	AIOECU_DEST_CNT1_STOP				= 131,			//�J�E���^�P�A�^�C�}�P�����~�M��
	AIOECU_DEST_MASTER1					= 104,			//�����o�X�}�X�^�M���P
	AIOECU_DEST_MASTER2					= 105,			//�����o�X�}�X�^�M���Q
	AIOECU_DEST_MASTER3					= 106,			//�����o�X�}�X�^�M���R

	// �C�x���g�R���g���[���ڑ����M��
	AIOECU_SRC_OPEN						= -1,			//���ڑ�
	AIOECU_SRC_AI_CLK					= 4,			//�A�i���O���͓����N���b�N�M��
	AIOECU_SRC_AI_EXTCLK				= 146,			//�A�i���O���͊O���N���b�N�M��
	AIOECU_SRC_AI_TRGSTART				= 144,			//�A�i���O���͊O���g���K�J�n�M��
	AIOECU_SRC_AI_LVSTART				= 28,			//�A�i���O���̓��x���g���K�J�n�M��
	AIOECU_SRC_AI_STOP					= 17,			//�A�i���O���͕ϊ��񐔏I���M���i�x���Ȃ��j
	AIOECU_SRC_AI_STOP_DELAY			= 18,			//�A�i���O���͕ϊ��񐔏I���M���i�x������j
	AIOECU_SRC_AI_LVSTOP				= 29,			//�A�i���O���̓��x���g���K��~�M��
	AIOECU_SRC_AI_TRGSTOP				= 145,			//�A�i���O���͊O���g���K��~�M��
	AIOECU_SRC_AO_CLK					= 66,			//�A�i���O�o�͓����N���b�N�M��
	AIOECU_SRC_AO_EXTCLK				= 149,			//�A�i���O�o�͊O���N���b�N�M��
	AIOECU_SRC_AO_TRGSTART				= 147,			//�A�i���O�o�͊O���g���K�J�n�M��
	AIOECU_SRC_AO_STOP_FIFO				= 352,			//�A�i���O�o�͎w��񐔏o�͏I���M���iFIFO�g�p�j
	AIOECU_SRC_AO_STOP_RING				= 80,			//�A�i���O�o�͎w��񐔏o�͏I���M���iRING�g�p�j
	AIOECU_SRC_AO_TRGSTOP				= 148,			//�A�i���O�o�͊O���g���K��~�M��
	AIOECU_SRC_CNT0_UPCLK				= 150,			//�J�E���^�O�A�b�v�N���b�N�M��
	AIOECU_SRC_CNT1_UPCLK				= 152,			//�J�E���^�P�A�b�v�N���b�N�M��
	AIOECU_SRC_CNT0_CMP					= 288,			//�J�E���^�O��r�J�E���g��v
	AIOECU_SRC_CNT1_CMP					= 289,			//�J�E���^�P��r�J�E���g��v
	AIOECU_SRC_SLAVE1					= 136,			//�����o�X�X���[�u�M���P
	AIOECU_SRC_SLAVE2					= 137,			//�����o�X�X���[�u�M���Q
	AIOECU_SRC_SLAVE3					= 138,			//�����o�X�X���[�u�M���R
	AIOECU_SRC_START					= 384,			//Ai, Ao, Cnt, Tm�\�t�g�E�F�A�J�n�M��
	AIOECU_SRC_STOP						= 385,			//Ai, Ao, Cnt, Tm�\�t�g�E�F�A��~�M��
	
}

namespace CaioCs
{
	unsafe public delegate int PAICALLBACK(short Id, short Message, int wParam, int lParam, void *Param);
	unsafe public delegate int PAOCALLBACK(short Id, short Message, int wParam, int lParam, void *Param);
	unsafe public delegate int PCNTCALLBACK(short Id, short Message, int wParam, int lParam, void *Param);
	unsafe public delegate int PTMCALLBACK(short Id, short Message, int wParam, int lParam, void *Param);
	
	// Start for M-device
	unsafe public delegate int PAIOCNTMCOUNTUPCALLBACK(short Id, int wParam, int lParam, void *Param);
	unsafe public delegate int PAIOCNTMCOUNTERERRORCALLBACK(short Id, int wParam, int lParam, void *Param);
	unsafe public delegate int PAIOCNTMCARRYBORROWCALLBACK(short Id, int wParam, int lParam, void *Param);
	unsafe public delegate int PAIOCNTMTMCALLBACK(short Id, int wParam, int lParam, void *Param);
	// End for M-device

	/// <summary>
	/// Caio �̊T�v�̐����ł��B
	/// </summary>
	public class Caio
	{
		/// <summary>
		/// �A���}�l�[�WDLL(CAIO.DLL)�̃C���|�[�g
		/// </summary>
		// ���ʊ֐�
		[DllImport("caio.dll")] static extern int AioInit(string DeviceName, ref short Id);
		[DllImport("caio.dll")] static extern int AioExit(short Id);
		[DllImport("caio.dll")] static extern int AioResetDevice(short Id);
		[DllImport("caio.dll")] static extern int AioGetErrorString(int ErrorCode, System.Text.StringBuilder ErrorString);
		[DllImport("caio.dll")] static extern int AioQueryDeviceName(short Index, System.Text.StringBuilder DeviceName, System.Text.StringBuilder Device);
		[DllImport("caio.dll")] static extern int AioGetDeviceType(string Device, ref short DeviceType);
		[DllImport("caio.dll")] static extern int AioSetControlFilter(short Id, short Signal, float Value);
		[DllImport("caio.dll")] static extern int AioGetControlFilter(short Id, short Signal, ref float Value);
		[DllImport("caio.dll")] static extern int AioResetProcess(short Id);
		
		// �A�i���O���͊֐�
		[DllImport("caio.dll")] static extern int AioSingleAi(short Id, short AiChannel, ref int AiData);
		[DllImport("caio.dll")] static extern int AioSingleAiEx(short Id, short AiChannel, ref float AiData);
		[DllImport("caio.dll")] static extern int AioMultiAi(short Id, short AiChannels, [MarshalAs(UnmanagedType.LPArray)] int[] AiData);
		[DllImport("caio.dll")] static extern int AioMultiAiEx(short Id, short AiChannels, [MarshalAs(UnmanagedType.LPArray)] float[] AiData);
		[DllImport("caio.dll")] static extern int AioGetAiResolution(short Id, ref short AiResolution);
		[DllImport("caio.dll")] static extern int AioSetAiInputMethod(short Id, short AiInputMethod);
		[DllImport("caio.dll")] static extern int AioGetAiInputMethod(short Id, ref short AiInputMethod);
		[DllImport("caio.dll")] static extern int AioGetAiMaxChannels(short Id, ref short AiMaxChannels);
		[DllImport("caio.dll")] static extern int AioSetAiChannel(short Id, short AiChannel, short Enabled);
		[DllImport("caio.dll")] static extern int AioGetAiChannel(short Id, short AiChannel, ref short Enabled);
		[DllImport("caio.dll")] static extern int AioSetAiChannels(short Id, short AiChannels);
		[DllImport("caio.dll")] static extern int AioGetAiChannels(short Id, ref short AiChannels);
		[DllImport("caio.dll")] static extern int AioSetAiChannelSequence(short Id, short AiSequence, short AiChannel);
		[DllImport("caio.dll")] static extern int AioGetAiChannelSequence(short Id, short AiSequence, ref short AiChannel);
		[DllImport("caio.dll")] static extern int AioSetAiRange(short Id, short AiChannel, short AiRange);
		[DllImport("caio.dll")] static extern int AioSetAiRangeAll(short Id, short AiRange);
		[DllImport("caio.dll")] static extern int AioGetAiRange(short Id, short AiChannel, ref short AiRange);
		[DllImport("caio.dll")] static extern int AioSetAiTransferMode(short Id, short AiTransferMode);
		[DllImport("caio.dll")] static extern int AioGetAiTransferMode(short Id, ref short AiTransferMode);
		[DllImport("caio.dll")] static extern int AioSetAiDeviceBufferMode(short Id, short AiDeviceBufferMode);
		[DllImport("caio.dll")] static extern int AioGetAiDeviceBufferMode(short Id, ref short AiDeviceBufferMode);
		[DllImport("caio.dll")] static extern int AioSetAiMemorySize(short Id, int AiMemorySize);
		[DllImport("caio.dll")] static extern int AioGetAiMemorySize(short Id, ref int AiMemorySize);
		[DllImport("caio.dll")] static extern int AioSetAiTransferData(short Id, int DataNumber, IntPtr Buffer);
		[DllImport("caio.dll")] static extern int AioSetAiAttachedData(short Id, int AttachedData);
		[DllImport("caio.dll")] static extern int AioGetAiSamplingDataSize(short Id, ref short DataSize);
		[DllImport("caio.dll")] static extern int AioSetAiMemoryType(short Id, short AiMemoryType);
		[DllImport("caio.dll")] static extern int AioGetAiMemoryType(short Id, ref short AiMemoryType);
		[DllImport("caio.dll")] static extern int AioSetAiRepeatTimes(short Id, int AiRepeatTimes);
		[DllImport("caio.dll")] static extern int AioGetAiRepeatTimes(short Id, ref int AiRepeatTimes);
		[DllImport("caio.dll")] static extern int AioSetAiClockType(short Id, short AiClockType);
		[DllImport("caio.dll")] static extern int AioGetAiClockType(short Id, ref short AiClockType);
		[DllImport("caio.dll")] static extern int AioSetAiSamplingClock(short Id, float AiSamplingClock);
		[DllImport("caio.dll")] static extern int AioGetAiSamplingClock(short Id, ref float AiSamplingClock);
		[DllImport("caio.dll")] static extern int AioSetAiScanClock(short Id, float AiScanClock);
		[DllImport("caio.dll")] static extern int AioGetAiScanClock(short Id, ref float AiScanClock);
		[DllImport("caio.dll")] static extern int AioSetAiClockEdge(short Id, short AiClockEdge);
		[DllImport("caio.dll")] static extern int AioGetAiClockEdge(short Id, ref short AiClockEdge);
		[DllImport("caio.dll")] static extern int AioSetAiStartTrigger(short Id, short AiStartTrigger);
		[DllImport("caio.dll")] static extern int AioGetAiStartTrigger(short Id, ref short AiStartTrigger);
		[DllImport("caio.dll")] static extern int AioSetAiStartLevel(short Id, short AiChannel, int AiStartLevel, short AiDirection);
		[DllImport("caio.dll")] static extern int AioSetAiStartLevelEx(short Id, short AiChannel, float AiStartLevel, short AiDirection);
		[DllImport("caio.dll")] static extern int AioGetAiStartLevel(short Id, short AiChannel, ref int AiStartLevel, ref short AiDirection);
		[DllImport("caio.dll")] static extern int AioGetAiStartLevelEx(short Id, short AiChannel, ref float AiStartLevel, ref short AiDirection);
		[DllImport("caio.dll")] static extern int AioSetAiStartInRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStartInRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStartInRange(short Id, short AiChannel, ref int Level1, ref int Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStartInRangeEx(short Id, short AiChannel, ref float Level1, ref float Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStartOutRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStartOutRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStartOutRange(short Id, short AiChannel, ref int Level1, ref int Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStartOutRangeEx(short Id, short AiChannel, ref float Level1, ref float Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStopTrigger(short Id, short AiStopTrigger);
		[DllImport("caio.dll")] static extern int AioGetAiStopTrigger(short Id, ref short AiStopTrigger);
		[DllImport("caio.dll")] static extern int AioSetAiStopTimes(short Id, int AiStopTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStopTimes(short Id, ref int AiStopTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStopLevel(short Id, short AiChannel, int AiStopLevel, short AiDirection);
		[DllImport("caio.dll")] static extern int AioSetAiStopLevelEx(short Id, short AiChannel, float AiStopLevel, short AiDirection);
		[DllImport("caio.dll")] static extern int AioGetAiStopLevel(short Id, short AiChannel, ref int AiStopLevel, ref short AiDirection);
		[DllImport("caio.dll")] static extern int AioGetAiStopLevelEx(short Id, short AiChannel, ref float AiStopLevel, ref short AiDirection);
		[DllImport("caio.dll")] static extern int AioSetAiStopInRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStopInRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStopInRange(short Id, short AiChannel, ref int Level1, ref int Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStopInRangeEx(short Id, short AiChannel, ref float Level1, ref float Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStopOutRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStopOutRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStopOutRange(short Id, short AiChannel, ref int Level1, ref int Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStopOutRangeEx(short Id, short AiChannel, ref float Level1, ref float Level2, ref int StateTimes);
		[DllImport("caio.dll")] static extern int AioSetAiStopDelayTimes(short Id, int AiStopDelayTimes);
		[DllImport("caio.dll")] static extern int AioGetAiStopDelayTimes(short Id, ref int AiStopDelayTimes);
		[DllImport("caio.dll")] static extern int AioSetAiEvent(short Id, uint hWnd, int AiEvent);
		[DllImport("caio.dll")] static extern int AioGetAiEvent(short Id, ref uint hWnd, ref int AiEvent);
		[DllImport("caio.dll")] unsafe static extern int AioSetAiCallBackProc(short Id, PAICALLBACK pAiCallBack, int AiEvent, void *Param);
		[DllImport("caio.dll")] static extern int AioSetAiEventSamplingTimes(short Id, int AiSamplingTimes);
		[DllImport("caio.dll")] static extern int AioGetAiEventSamplingTimes(short Id, ref int AiSamplingTimes);
		[DllImport("caio.dll")] static extern int AioSetAiEventTransferTimes(short Id, int AiTransferTimes);
		[DllImport("caio.dll")] static extern int AioGetAiEventTransferTimes(short Id, ref int AiTransferTimes);
		[DllImport("caio.dll")] static extern int AioStartAi(short Id);
		[DllImport("caio.dll")] static extern int AioStartAiSync(short Id, int TimeOut);
		[DllImport("caio.dll")] static extern int AioStopAi(short Id);
		[DllImport("caio.dll")] static extern int AioGetAiStatus(short Id, ref int AiStatus);
		[DllImport("caio.dll")] static extern int AioGetAiSamplingCount(short Id, ref int AiSamplingCount);
		[DllImport("caio.dll")] static extern int AioGetAiStopTriggerCount(short Id, ref int AiStopTriggerCount);
		[DllImport("caio.dll")] static extern int AioGetAiTransferCount(short Id, ref int AiTransferCount);
		[DllImport("caio.dll")] static extern int AioGetAiTransferLap(short Id, ref int Lap);
		[DllImport("caio.dll")] static extern int AioGetAiStopTriggerTransferCount(short Id, ref int Count);
		[DllImport("caio.dll")] static extern int AioGetAiRepeatCount(short Id, ref int AiRepeatCount);
		[DllImport("caio.dll")] static extern int AioGetAiSamplingData(short Id, ref int AiSamplingTimes, [MarshalAs(UnmanagedType.LPArray)] int[] AiData);
		[DllImport("caio.dll")] static extern int AioGetAiSamplingDataEx(short Id, ref int AiSamplingTimes, [MarshalAs(UnmanagedType.LPArray)] float[] AiData);
		[DllImport("caio.dll")] static extern int AioResetAiStatus(short Id);
		[DllImport("caio.dll")] static extern int AioResetAiMemory(short Id);
		
		// �A�i���O�o�͊֐�
		[DllImport("caio.dll")] static extern int AioSingleAo(short Id, short AoChannel, int AoData);
		[DllImport("caio.dll")] static extern int AioSingleAoEx(short Id, short AoChannel, float AoData);
		[DllImport("caio.dll")] static extern int AioMultiAo(short Id, short AoChannels, [MarshalAs(UnmanagedType.LPArray)] int[] AoData);
		[DllImport("caio.dll")] static extern int AioMultiAoEx(short Id, short AoChannels, [MarshalAs(UnmanagedType.LPArray)] float[] AoData);
		[DllImport("caio.dll")] static extern int AioGetAoResolution(short Id, ref short AoResolution);
		[DllImport("caio.dll")] static extern int AioSetAoChannels(short Id, short AoChannels);
		[DllImport("caio.dll")] static extern int AioGetAoChannels(short Id, ref short AoChannels);
		[DllImport("caio.dll")] static extern int AioGetAoMaxChannels(short Id, ref short AoMaxChannels);
		[DllImport("caio.dll")] static extern int AioSetAoRange(short Id, short AoChannel, short AoRange);
		[DllImport("caio.dll")] static extern int AioSetAoRangeAll(short Id, short AoRange);
		[DllImport("caio.dll")] static extern int AioGetAoRange(short Id, short AoChannel, ref short AoRange);
		[DllImport("caio.dll")] static extern int AioSetAoTransferMode(short Id, short AoTransferMode);
		[DllImport("caio.dll")] static extern int AioGetAoTransferMode(short Id, ref short AoTransferMode);
		[DllImport("caio.dll")] static extern int AioSetAoDeviceBufferMode(short Id, short AoDeviceBufferMode);
		[DllImport("caio.dll")] static extern int AioGetAoDeviceBufferMode(short Id, ref short AoDeviceBufferMode);
		[DllImport("caio.dll")] static extern int AioSetAoMemorySize(short Id, int AoMemorySize);
		[DllImport("caio.dll")] static extern int AioGetAoMemorySize(short Id, ref int AoMemorySize);
		[DllImport("caio.dll")] static extern int AioSetAoTransferData(short Id, int DataNumber, IntPtr Buffer);
		[DllImport("caio.dll")] static extern int AioGetAoSamplingDataSize(short Id, ref short DataSize);
		[DllImport("caio.dll")] static extern int AioSetAoMemoryType(short Id, short AoMemoryType);
		[DllImport("caio.dll")] static extern int AioGetAoMemoryType(short Id, ref short AoMemoryType);
		[DllImport("caio.dll")] static extern int AioSetAoRepeatTimes(short Id, int AoRepeatTimes);
		[DllImport("caio.dll")] static extern int AioGetAoRepeatTimes(short Id, ref int AoRepeatTimes);
		[DllImport("caio.dll")] static extern int AioSetAoClockType(short Id, short AoClockType);
		[DllImport("caio.dll")] static extern int AioGetAoClockType(short Id, ref short AoClockType);
		[DllImport("caio.dll")] static extern int AioSetAoSamplingClock(short Id, float AoSamplingClock);
		[DllImport("caio.dll")] static extern int AioGetAoSamplingClock(short Id, ref float AoSamplingClock);
		[DllImport("caio.dll")] static extern int AioSetAoClockEdge(short Id, short AoClockEdge);
		[DllImport("caio.dll")] static extern int AioGetAoClockEdge(short Id, ref short AoClockEdge);
		[DllImport("caio.dll")] static extern int AioSetAoSamplingData(short Id, int AoSamplingTimes, [MarshalAs(UnmanagedType.LPArray)] int[] AoData);
		[DllImport("caio.dll")] static extern int AioSetAoSamplingDataEx(short Id, int AoSamplingTimes, [MarshalAs(UnmanagedType.LPArray)] float[] AoData);
		[DllImport("caio.dll")] static extern int AioGetAoSamplingTimes(short Id, ref int AoSamplingTimes);
		[DllImport("caio.dll")] static extern int AioSetAoStartTrigger(short Id, short AoStartTrigger);
		[DllImport("caio.dll")] static extern int AioGetAoStartTrigger(short Id, ref short AoStartTrigger);
		[DllImport("caio.dll")] static extern int AioSetAoStopTrigger(short Id, short AoStopTrigger);
		[DllImport("caio.dll")] static extern int AioGetAoStopTrigger(short Id, ref short AoStopTrigger);
		[DllImport("caio.dll")] static extern int AioSetAoEvent(short Id, uint hWnd, int AoEvent);
		[DllImport("caio.dll")] static extern int AioGetAoEvent(short Id, ref uint hWnd, ref int AoEvent);
		[DllImport("caio.dll")] unsafe static extern int AioSetAoCallBackProc(short Id, PAOCALLBACK pAoCallBack, int AoEvent, void *Param);
		[DllImport("caio.dll")] static extern int AioSetAoEventSamplingTimes(short Id, int AoSamplingTimes);
		[DllImport("caio.dll")] static extern int AioGetAoEventSamplingTimes(short Id, ref int AoSamplingTimes);
		[DllImport("caio.dll")] static extern int AioSetAoEventTransferTimes(short Id, int AoTransferTimes);
		[DllImport("caio.dll")] static extern int AioGetAoEventTransferTimes(short Id, ref int AoTransferTimes);
		[DllImport("caio.dll")] static extern int AioStartAo(short Id);
		[DllImport("caio.dll")] static extern int AioStopAo(short Id);
		[DllImport("caio.dll")] static extern int AioEnableAo(short Id, short AoChannel);
		[DllImport("caio.dll")] static extern int AioDisableAo(short Id, short AoChannel);
		[DllImport("caio.dll")] static extern int AioGetAoStatus(short Id, ref int AoStatus);
		[DllImport("caio.dll")] static extern int AioGetAoSamplingCount(short Id, ref int AoSamplingCount);
		[DllImport("caio.dll")] static extern int AioGetAoTransferCount(short Id, ref int AoTransferCount);
		[DllImport("caio.dll")] static extern int AioGetAoTransferLap(short Id, ref int Lap);
		[DllImport("caio.dll")] static extern int AioGetAoRepeatCount(short Id, ref int AoRepeatCount);
		[DllImport("caio.dll")] static extern int AioResetAoStatus(short Id);
		[DllImport("caio.dll")] static extern int AioResetAoMemory(short Id);
		
		// �f�W�^�����o�͊֐�
		[DllImport("caio.dll")] static extern int AioSetDiFilter(short Id, short Bit, float Value);
		[DllImport("caio.dll")] static extern int AioGetDiFilter(short Id, short Bit, ref float Value);
		[DllImport("caio.dll")] static extern int AioInputDiBit(short Id, short DiBit, ref short DiData);
		[DllImport("caio.dll")] static extern int AioOutputDoBit(short Id, short DoBit, short DoData);
		[DllImport("caio.dll")] static extern int AioInputDiByte(short Id, short DiPort, ref short DiData);
		[DllImport("caio.dll")] static extern int AioOutputDoByte(short Id, short DoPort, short DoData);
		[DllImport("caio.dll")] static extern int AioSetDioDirection(short Id, int Dir);
		[DllImport("caio.dll")] static extern int AioGetDioDirection(short Id, ref int Dir);
		
		// �J�E���^�֐�
		[DllImport("caio.dll")] static extern int AioGetCntMaxChannels(short Id, ref short CntMaxChannels);
		[DllImport("caio.dll")] static extern int AioSetCntComparisonMode(short Id, short CntChannel, short CntMode);
		[DllImport("caio.dll")] static extern int AioGetCntComparisonMode(short Id, short CntChannel, ref short CntMode);
		[DllImport("caio.dll")] static extern int AioSetCntPresetReg(short Id, short CntChannel, int PresetNumber, [MarshalAs(UnmanagedType.LPArray)] int[] PresetData, short Flag);
		[DllImport("caio.dll")] static extern int AioSetCntComparisonReg(short Id, short CntChannel, int ComparisonNumber, [MarshalAs(UnmanagedType.LPArray)] int[] ComparisonData, short Flag);
		[DllImport("caio.dll")] static extern int AioSetCntInputSignal(short Id, short CntChannel, short CntInputSignal);
		[DllImport("caio.dll")] static extern int AioGetCntInputSignal(short Id, short CntChannel, ref short CntInputSignal);
		[DllImport("caio.dll")] static extern int AioSetCntEvent(short Id, short CntChannel, uint hWnd, int CntEvent);
		[DllImport("caio.dll")] static extern int AioGetCntEvent(short Id, short CntChannel, ref uint hWnd, ref int CntEvent);
		[DllImport("caio.dll")] unsafe static extern int AioSetCntCallBackProc(short Id, short CntChannel, PCNTCALLBACK pCntCallBack, int CntEvent, void *Param);
		[DllImport("caio.dll")] static extern int AioSetCntFilter(short Id, short CntChannel, short Signal, float Value);
		[DllImport("caio.dll")] static extern int AioGetCntFilter(short Id, short CntChannel, short Signal, ref float Value);
		[DllImport("caio.dll")] static extern int AioStartCnt(short Id, short CntChannel);
		[DllImport("caio.dll")] static extern int AioStopCnt(short Id, short CntChannel);
		[DllImport("caio.dll")] static extern int AioPresetCnt(short Id, short CntChannel, int PresetData);
		[DllImport("caio.dll")] static extern int AioGetCntStatus(short Id, short CntChannel, ref int CntStatus);
		[DllImport("caio.dll")] static extern int AioGetCntCount(short Id, short CntChannel, ref int Count);
		[DllImport("caio.dll")] static extern int AioResetCntStatus(short Id, short CntChannel, int CntStatus);
		
		// �^�C�}�֐�
		[DllImport("caio.dll")] static extern int AioSetTmEvent(short Id, short TimerId, uint hWnd, int TmEvent);
		[DllImport("caio.dll")] static extern int AioGetTmEvent(short Id, short TimerId, ref uint hWnd, ref int TmEvent);
		[DllImport("caio.dll")] unsafe static extern int AioSetTmCallBackProc(short Id, short TimerId, PTMCALLBACK pTmCallBack, int TmEvent, void *Param);
		[DllImport("caio.dll")] static extern int AioStartTmTimer(short Id, short TimerId, float Interval);
		[DllImport("caio.dll")] static extern int AioStopTmTimer(short Id, short TimerId);
		[DllImport("caio.dll")] static extern int AioStartTmCount(short Id, short TimerId);
		[DllImport("caio.dll")] static extern int AioStopTmCount(short Id, short TimerId);
		[DllImport("caio.dll")] static extern int AioLapTmCount(short Id, short TimerId, ref int Lap);
		[DllImport("caio.dll")] static extern int AioResetTmCount(short Id, short TimerId);
		[DllImport("caio.dll")] static extern int AioTmWait(short Id, short TimerId, int Wait);
		
		// �C�x���g�R���g���[��
		[DllImport("caio.dll")] static extern int AioSetEcuSignal(short Id, short Destination, short Source);
		[DllImport("caio.dll")] static extern int AioGetEcuSignal(short Id, short Destination, ref short Source);
		
		
		// Setting function (set)
		[DllImport("caio.dll")] static extern int AioGetCntmMaxChannels(short Id, ref short CntmMaxChannels);
		[DllImport("caio.dll")] static extern int AioSetCntmZMode(short Id, short ChNo, short Mode);
		[DllImport("caio.dll")] static extern int AioSetCntmZLogic(short Id, short ChNo, short ZLogic);
		[DllImport("caio.dll")] static extern int AioSelectCntmChannelSignal(short Id, short ChNo, short SigType);
		[DllImport("caio.dll")] static extern int AioSetCntmCountDirection(short Id, short ChNo, short Dir);
		[DllImport("caio.dll")] static extern int AioSetCntmOperationMode(short Id, short ChNo, short Phase, short Mul, short SyncClr);
		[DllImport("caio.dll")] static extern int AioSetCntmDigitalFilter(short Id, short ChNo, short FilterValue);
		[DllImport("caio.dll")] static extern int AioSetCntmPulseWidth(short Id, short ChNo, short PlsWidth);
		[DllImport("caio.dll")] static extern int AioSetCntmDIType(short Id, short ChNo, short InputType);
		[DllImport("caio.dll")] static extern int AioSetCntmOutputHardwareEvent(short Id, short ChNo, short OutputLogic, uint EventType, short PulseWidth);
		[DllImport("caio.dll")] static extern int AioSetCntmInputHardwareEvent(short Id, short ChNo, uint EventType, short RF0, short RF1, short Reserved);
		[DllImport("caio.dll")] static extern int AioSetCntmCountMatchHardwareEvent(short Id, short ChNo, short RegisterNo, uint EventType, short Reserved);
		[DllImport("caio.dll")] static extern int AioSetCntmPresetRegister(short Id, short ChNo, uint PresetData, short Reserved);
		[DllImport("caio.dll")] static extern int AioSetCntmTestPulse(short Id, short CntmInternal, short CntmOut, short CntmReserved);
		
		// Setting function (get)
		[DllImport("caio.dll")] static extern int AioGetCntmZMode(short Id, short ChNo, ref short Mode);
		[DllImport("caio.dll")] static extern int AioGetCntmZLogic(short Id, short ChNo,ref short ZLogic);
		[DllImport("caio.dll")] static extern int AioGetCntmChannelSignal(short Id, short CntmChNo, ref short CntmSigType);
		[DllImport("caio.dll")] static extern int AioGetCntmCountDirection(short Id, short ChNo, ref short Dir);
		[DllImport("caio.dll")] static extern int AioGetCntmOperationMode(short Id, short ChNo, ref short Phase, ref short Mul, ref short SyncClr);
		[DllImport("caio.dll")] static extern int AioGetCntmDigitalFilter(short Id, short ChNo, ref short FilterValue);
		[DllImport("caio.dll")] static extern int AioGetCntmPulseWidth(short Id, short ChNo, ref short PlsWidth);
		
		// Counter function
		[DllImport("caio.dll")] static extern int AioCntmStartCount(short Id, [MarshalAs(UnmanagedType.LPArray)] short[] ChNo, short ChNum);
		[DllImport("caio.dll")] static extern int AioCntmStopCount(short Id, [MarshalAs(UnmanagedType.LPArray)] short[] ChNo, short ChNum);
		[DllImport("caio.dll")] static extern int AioCntmPreset(short Id, [MarshalAs(UnmanagedType.LPArray)] short[] ChNo, short ChNum, [MarshalAs(UnmanagedType.LPArray)] uint[] PresetData);
		[DllImport("caio.dll")] static extern int AioCntmZeroClearCount(short Id, [MarshalAs(UnmanagedType.LPArray)] short[] ChNo, short ChNum);
		[DllImport("caio.dll")] static extern int AioCntmReadCount(short Id, [MarshalAs(UnmanagedType.LPArray)] short[] ChNo, short ChNum, [MarshalAs(UnmanagedType.LPArray)] uint[] CntDat);
		[DllImport("caio.dll")] static extern int AioCntmReadStatus(short Id, short ChNo, ref short Sts);
		[DllImport("caio.dll")] static extern int AioCntmReadStatusEx(short Id, short ChNo, ref uint Sts);
		
		// Notify function
		[DllImport("caio.dll")] static extern int AioCntmNotifyCountUp(short Id, short ChNo, short RegNo, uint Count, int hWnd);
		[DllImport("caio.dll")] static extern int AioCntmStopNotifyCountUp(short Id, short ChNo, short RegNo);
		[DllImport("caio.dll")] unsafe static extern int AioCntmCountUpCallbackProc(short Id , PAIOCNTMCOUNTUPCALLBACK pAioCntmCountUpCallBack, void *Param);
		[DllImport("caio.dll")] static extern int AioCntmNotifyCounterError(short Id, int hWnd);
		[DllImport("caio.dll")] static extern int AioCntmStopNotifyCounterError(short Id);
		[DllImport("caio.dll")] unsafe static extern int AioCntmCounterErrorCallbackProc(short Id, PAIOCNTMCOUNTERERRORCALLBACK pAioCntmCounterErrorCallBack, void *Param);
		[DllImport("caio.dll")] static extern int AioCntmNotifyCarryBorrow(short Id, int hWnd);
		[DllImport("caio.dll")] static extern int AioCntmStopNotifyCarryBorrow(short Id);
		[DllImport("caio.dll")] unsafe static extern int AioCntmCarryBorrowCallbackProc(short Id, PAIOCNTMCARRYBORROWCALLBACK pAioCntmCarryBorrowCallBack, void *Param);
		[DllImport("caio.dll")] static extern int AioCntmNotifyTimer(short Id, uint TimeValue, int hWnd);
		[DllImport("caio.dll")] static extern int AioCntmStopNotifyTimer(short Id);
		[DllImport("caio.dll")] unsafe static extern int AioCntmTimerCallbackProc(short Id, PAIOCNTMTMCALLBACK pAioCntmTmCallBack, void *Param);
		
		// General purpose input function
		[DllImport("caio.dll")] static extern int AioCntmInputDIByte(short Id, short Reserved, ref byte bData);
		[DllImport("caio.dll")] static extern int AioCntmOutputDOBit(short Id, short AiomChNo, short Reserved, byte OutData);

		// �R���X�g���N�^
		public Caio()
		{
		}
		// ���ʊ֐�
		public int Init(string DeviceName, out short Id)
		{
			Id = 0;
			int ret = AioInit(DeviceName, ref Id);
			return ret;
		}
		public int Exit(short Id)
		{
			int ret = AioExit(Id);
			return ret;
		}
		public int ResetDevice(short Id)
		{
			int ret = AioResetDevice(Id);
			return ret;
		}
		public int GetErrorString(int ErrorCode, out string ErrorString)
		{
			ErrorString = new String('0',1);
			System.Text.StringBuilder errorstring = new System.Text.StringBuilder(256);
			int ret = AioGetErrorString(ErrorCode, errorstring);
			if(ret == 0)
			{
				ErrorString = errorstring.ToString();
			}
			return ret;
		}
		public int QueryDeviceName(short Index, out string DeviceName, out string Device)
		{
			DeviceName = new String('0',1);
			Device = new String('0',1);
			System.Text.StringBuilder devicename = new System.Text.StringBuilder(256);
			System.Text.StringBuilder device = new System.Text.StringBuilder(256);
			int ret = AioQueryDeviceName(Index, devicename, device);
			if(ret == 0)
			{
				DeviceName = devicename.ToString();
				Device = device.ToString();
			}
			return ret;
		}
		public int GetDeviceType(string Device, out short DeviceType)
		{
			DeviceType = 0;
			int ret = AioGetDeviceType(Device, ref DeviceType);
			return ret;
		}
		public int SetControlFilter(short Id, short Signal, float Value)
		{
			int ret = AioSetControlFilter(Id, Signal, Value);
			return ret;
		}
		public int GetControlFilter(short Id, short Signal, out float Value)
		{
			Value = 0;
			int ret = AioGetControlFilter(Id, Signal, ref Value);
			return ret;
		}
		public int ResetProcess(short Id)
		{
			int ret = AioResetProcess(Id);
			return ret;
		}
		
		// �A�i���O���͊֐�
		public int SingleAi(short Id, short AiChannel, out int AiData)
		{
			AiData = 0;
			int ret = AioSingleAi(Id, AiChannel, ref AiData);
			return ret;
		}
		public int SingleAiEx(short Id, short AiChannel, out float AiData)
		{
			AiData = 0;
			int ret = AioSingleAiEx(Id, AiChannel, ref AiData);
			return ret;
		}
		public int MultiAi(short Id, short AiChannels, int[] AiData)
		{
			int ret = AioMultiAi(Id, AiChannels, AiData);
			return ret;
		}
		public int MultiAiEx(short Id, short AiChannels, float[] AiData)
		{
			int ret = AioMultiAiEx(Id, AiChannels, AiData);
			return ret;
		}
		public int GetAiResolution(short Id, out short AiResolution)
		{
			AiResolution = 0;
			int ret = AioGetAiResolution(Id, ref AiResolution);
			return ret;
		}
		public int SetAiInputMethod(short Id, short AiInputMethod)
		{
			int ret = AioSetAiInputMethod(Id, AiInputMethod);
			return ret;
		}
		public int GetAiInputMethod(short Id, out short AiInputMethod)
		{
			AiInputMethod = 0;
			int ret = AioGetAiInputMethod(Id, ref AiInputMethod);
			return ret;
		}
		public int GetAiMaxChannels(short Id, out short AiMaxChannels)
		{
			AiMaxChannels = 0;
			int ret = AioGetAiMaxChannels(Id, ref AiMaxChannels);
			return ret;
		}
		public int SetAiChannel(short Id, short AiChannel, short Enabled)
		{
			int ret = AioSetAiChannel(Id, AiChannel, Enabled);
			return ret;
		}
		public int GetAiChannel(short Id, short AiChannels, out short Enabled)
		{
			Enabled = 0;
			int ret = AioGetAiChannel(Id, AiChannels, ref Enabled);
			return ret;
		}
		public int SetAiChannels(short Id, short AiChannels)
		{
			int ret = AioSetAiChannels(Id, AiChannels);
			return ret;
		}
		public int GetAiChannels(short Id, out short AiChannels)
		{
			AiChannels = 0;
			int ret = AioGetAiChannels(Id, ref AiChannels);
			return ret;
		}
		public int SetAiChannelSequence(short Id, short AiSequence, short AiChannel)
		{
			int ret = AioSetAiChannelSequence(Id, AiSequence, AiChannel);
			return ret;
		}
		public int GetAiChannelSequence(short Id, short AiSequence, out short AiChannel)
		{
			AiChannel = 0;
			int ret = AioGetAiChannelSequence(Id, AiSequence, ref AiChannel);
			return ret;
		}
		public int SetAiRange(short Id, short AiChannel, short AiRange)
		{
			int ret = AioSetAiRange(Id, AiChannel, AiRange);
			return ret;
		}
		public int SetAiRangeAll(short Id, short AiRange)
		{
			int ret = AioSetAiRangeAll(Id, AiRange);
			return ret;
		}
		public int GetAiRange(short Id, short AiChannel, out short AiRange)
		{
			AiRange = 0;
			int ret = AioGetAiRange(Id, AiChannel, ref AiRange);
			return ret;
		}
		public int SetAiTransferMode(short Id, short AiTransferMode)
		{
			int ret = AioSetAiTransferMode(Id, AiTransferMode);
			return ret;
		}
		public int GetAiTransferMode(short Id, out short AiTransferMode)
		{
			AiTransferMode = 0;
			int ret = AioGetAiTransferMode(Id, ref AiTransferMode);
			return ret;
		}
		public int SetAiDeviceBufferMode(short Id, short AiDeviceBufferMode)
		{
			int ret = AioSetAiDeviceBufferMode(Id, AiDeviceBufferMode);
			return ret;
		}
		public int GetAiDeviceBufferMode(short Id, out short AiDeviceBufferMode)
		{
			AiDeviceBufferMode = 0;
			int ret = AioGetAiDeviceBufferMode(Id, ref AiDeviceBufferMode);
			return ret;
		}
		public int SetAiMemorySize(short Id, int AiMemorySize)
		{
			int ret = AioSetAiMemorySize(Id, AiMemorySize);
			return ret;
		}
		public int GetAiMemorySize(short Id, out int AiMemorySize)
		{
			AiMemorySize = 0;
			int ret = AioGetAiMemorySize(Id, ref AiMemorySize);
			return ret;
		}
		public int SetAiTransferData(short Id, int DataNumber, IntPtr Buffer)
		{
			int ret = AioSetAiTransferData(Id, DataNumber, Buffer);
			return ret;
		}
		public int SetAiAttachedData(short Id, int AttachedData)
		{
			int ret = AioSetAiAttachedData(Id, AttachedData);
			return ret;
		}
		public int GetAiSamplingDataSize(short Id, out short DataSize)
		{
			DataSize = 0;
			int ret = AioGetAiSamplingDataSize(Id, ref DataSize);
			return ret;
		}
		public int SetAiMemoryType(short Id, short AiMemoryType)
		{
			int ret = AioSetAiMemoryType(Id, AiMemoryType);
			return ret;
		}
		public int GetAiMemoryType(short Id, out short AiMemoryType)
		{
			AiMemoryType = 0;
			int ret = AioGetAiMemoryType(Id, ref AiMemoryType);
			return ret;
		}
		public int SetAiRepeatTimes(short Id, int AiRepeatTimes)
		{
			int ret = AioSetAiRepeatTimes(Id, AiRepeatTimes);
			return ret;
		}
		public int GetAiRepeatTimes(short Id, out int AiRepeatTimes)
		{
			AiRepeatTimes = 0;
			int ret = AioGetAiRepeatTimes(Id, ref AiRepeatTimes);
			return ret;
		}
		public int SetAiClockType(short Id, short AiClockType)
		{
			int ret = AioSetAiClockType(Id, AiClockType);
			return ret;
		}
		public int GetAiClockType(short Id, out short AiClockType)
		{
			AiClockType = 0;
			int ret = AioGetAiClockType(Id, ref AiClockType);
			return ret;
		}
		public int SetAiSamplingClock(short Id, float AiSamplingClock)
		{
			int ret = AioSetAiSamplingClock(Id, AiSamplingClock);
			return ret;
		}
		public int GetAiSamplingClock(short Id, out float AiSamplingClock)
		{
			AiSamplingClock = 0;
			int ret = AioGetAiSamplingClock(Id, ref AiSamplingClock);
			return ret;
		}
		public int SetAiScanClock(short Id, float AiScanClock)
		{
			int ret = AioSetAiScanClock(Id, AiScanClock);
			return ret;
		}
		public int GetAiScanClock(short Id, out float AiScanClock)
		{
			AiScanClock = 0;
			int ret = AioGetAiScanClock(Id, ref AiScanClock);
			return ret;
		}
		public int SetAiClockEdge(short Id, short AiClockEdge)
		{
			int ret = AioSetAiClockEdge(Id, AiClockEdge);
			return ret;
		}
		public int GetAiClockEdge(short Id, out short AiClockEdge)
		{
			AiClockEdge = 0;
			int ret = AioGetAiClockEdge(Id, ref AiClockEdge);
			return ret;
		}
		public int SetAiStartTrigger(short Id, short AiStartTrigger)
		{
			int ret = AioSetAiStartTrigger(Id, AiStartTrigger);
			return ret;
		}
		public int GetAiStartTrigger(short Id, out short AiStartTrigger)
		{
			AiStartTrigger = 0;
			int ret = AioGetAiStartTrigger(Id, ref AiStartTrigger);
			return ret;
		}
		public int SetAiStartLevel(short Id, short AiChannel, int AiStartLevel, short AiDirection)
		{
			int ret = AioSetAiStartLevel(Id, AiChannel, AiStartLevel, AiDirection);
			return ret;
		}
		public int SetAiStartLevelEx(short Id, short AiChannel, float AiStartLevel, short AiDirection)
		{
			int ret = AioSetAiStartLevelEx(Id, AiChannel, AiStartLevel, AiDirection);
			return ret;
		}
		public int GetAiStartLevel(short Id, short AiChannel, out int AiStartLevel, out short AiDirection)
		{
			AiStartLevel = 0;
			AiDirection = 0;
			int ret = AioGetAiStartLevel(Id, AiChannel, ref AiStartLevel, ref AiDirection);
			return ret;
		}
		public int GetAiStartLevelEx(short Id, short AiChannel, out float AiStartLevel, out short AiDirection)
		{
			AiStartLevel = 0;
			AiDirection = 0;
			int ret = AioGetAiStartLevelEx(Id, AiChannel, ref AiStartLevel, ref AiDirection);
			return ret;
		}
		public int SetAiStartInRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes)
		{
			int ret = AioSetAiStartInRange(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int SetAiStartInRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes)
		{
			int ret = AioSetAiStartInRangeEx(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int GetAiStartInRange(short Id, short AiChannel, out int Level1, out int Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStartInRange(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int GetAiStartInRangeEx(short Id, short AiChannel, out float Level1, out float Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStartInRangeEx(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int SetAiStartOutRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes)
		{
			int ret = AioSetAiStartOutRange(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int SetAiStartOutRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes)
		{
			int ret = AioSetAiStartOutRangeEx(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int GetAiStartOutRange(short Id, short AiChannel, out int Level1, out int Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStartOutRange(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int GetAiStartOutRangeEx(short Id, short AiChannel, out float Level1, out float Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStartOutRangeEx(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int SetAiStopTrigger(short Id, short AiStopTrigger)
		{
			int ret = AioSetAiStopTrigger(Id, AiStopTrigger);
			return ret;
		}
		public int GetAiStopTrigger(short Id, out short AiStopTrigger)
		{
			AiStopTrigger = 0;
			int ret = AioGetAiStopTrigger(Id, ref AiStopTrigger);
			return ret;
		}
		public int SetAiStopTimes(short Id, int AiStopTimes)
		{
			int ret = AioSetAiStopTimes(Id, AiStopTimes);
			return ret;
		}
		public int GetAiStopTimes(short Id, out int AiStopTimes)
		{
			AiStopTimes = 0;
			int ret = AioGetAiStopTimes(Id, ref AiStopTimes);
			return ret;
		}
		public int SetAiStopLevel(short Id, short AiChannel, int AiStopLevel, short AiDirection)
		{
			int ret = AioSetAiStopLevel(Id, AiChannel, AiStopLevel, AiDirection);
			return ret;
		}
		public int SetAiStopLevelEx(short Id, short AiChannel, float AiStopLevel, short AiDirection)
		{
			int ret = AioSetAiStopLevelEx(Id, AiChannel, AiStopLevel, AiDirection);
			return ret;
		}
		public int GetAiStopLevel(short Id, short AiChannel, out int AiStopLevel, out short AiDirection)
		{
			AiStopLevel = 0;
			AiDirection = 0;
			int ret = AioGetAiStopLevel(Id, AiChannel, ref AiStopLevel, ref AiDirection);
			return ret;
		}
		public int GetAiStopLevelEx(short Id, short AiChannel, out float AiStopLevel, out short AiDirection)
		{
			AiStopLevel = 0;
			AiDirection = 0;
			int ret = AioGetAiStopLevelEx(Id, AiChannel, ref AiStopLevel, ref AiDirection);
			return ret;
		}
		public int SetAiStopInRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes)
		{
			int ret = AioSetAiStopInRange(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int SetAiStopInRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes)
		{
			int ret = AioSetAiStopInRangeEx(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int GetAiStopInRange(short Id, short AiChannel, out int Level1, out int Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStopInRange(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int GetAiStopInRangeEx(short Id, short AiChannel, out float Level1, out float Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStopInRangeEx(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int SetAiStopOutRange(short Id, short AiChannel, int Level1, int Level2, int StateTimes)
		{
			int ret = AioSetAiStopOutRange(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int SetAiStopOutRangeEx(short Id, short AiChannel, float Level1, float Level2, int StateTimes)
		{
			int ret = AioSetAiStopOutRangeEx(Id, AiChannel, Level1, Level2, StateTimes);
			return ret;
		}
		public int GetAiStopOutRange(short Id, short AiChannel, out int Level1, out int Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStopOutRange(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int GetAiStopOutRangeEx(short Id, short AiChannel, out float Level1, out float Level2, out int StateTimes)
		{
			Level1 = 0;
			Level2 = 0;
			StateTimes = 0;
			int ret = AioGetAiStopOutRangeEx(Id, AiChannel, ref Level1, ref Level2, ref StateTimes);
			return ret;
		}
		public int SetAiStopDelayTimes(short Id, int AiStopDelayTimes)
		{
			int ret = AioSetAiStopDelayTimes(Id, AiStopDelayTimes);
			return ret;
		}
		public int GetAiStopDelayTimes(short Id, out int AiStopDelayTimes)
		{
			AiStopDelayTimes = 0;
			int ret = AioGetAiStopDelayTimes(Id, ref AiStopDelayTimes);
			return ret;
		}
		public int SetAiEvent(short Id, uint hWnd, int AiEvent)
		{
			int ret = AioSetAiEvent(Id, hWnd, AiEvent);
			return ret;
		}
		public int GetAiEvent(short Id, out uint hWnd, out int AiEvent)
		{
			hWnd = 0;
			AiEvent = 0;
			int ret = AioGetAiEvent(Id, ref hWnd, ref AiEvent);
			return ret;
		}
		unsafe public int SetAiCallBackProc(short Id, PAICALLBACK pAiCallBack, int AiEvent, void *Param)
		{
			int ret = AioSetAiCallBackProc(Id, pAiCallBack, AiEvent, Param);
			return ret;
		}
		public int SetAiEventSamplingTimes(short Id, int AiSamplingTimes)
		{
			int ret = AioSetAiEventSamplingTimes(Id, AiSamplingTimes);
			return ret;
		}
		public int GetAiEventSamplingTimes(short Id, out int AiSamplingTimes)
		{
			AiSamplingTimes = 0;
			int ret = AioGetAiEventSamplingTimes(Id, ref AiSamplingTimes);
			return ret;
		}
		public int SetAiEventTransferTimes(short Id, int AiTransferTimes)
		{
			int ret = AioSetAiEventTransferTimes(Id, AiTransferTimes);
			return ret;
		}
		public int GetAiEventTransferTimes(short Id, out int AiTransferTimes)
		{
			AiTransferTimes = 0;
			int ret = AioGetAiEventTransferTimes(Id, ref AiTransferTimes);
			return ret;
		}
		public int StartAi(short Id)
		{
			int ret = AioStartAi(Id);
			return ret;
		}
		public int StartAiSync(short Id, int TimeOut)
		{
			int ret = AioStartAiSync(Id, TimeOut);
			return ret;
		}
		public int StopAi(short Id)
		{
			int ret = AioStopAi(Id);
			return ret;
		}
		public int GetAiStatus(short Id, out int AiStatus)
		{
			AiStatus = 0;
			int ret = AioGetAiStatus(Id, ref AiStatus);
			return ret;
		}
		public int GetAiSamplingCount(short Id, out int AiSamplingCount)
		{
			AiSamplingCount = 0;
			int ret = AioGetAiSamplingCount(Id, ref AiSamplingCount);
			return ret;
		}
		public int GetAiStopTriggerCount(short Id, out int AiStopTriggerCount)
		{
			AiStopTriggerCount = 0;
			int ret = AioGetAiStopTriggerCount(Id, ref AiStopTriggerCount);
			return ret;
		}
		public int GetAiTransferCount(short Id, out int AiTransferCount)
		{
			AiTransferCount = 0;
			int ret = AioGetAiTransferCount(Id, ref AiTransferCount);
			return ret;
		}
		public int GetAiTransferLap(short Id, out int Lap)
		{
			Lap = 0;
			int ret = AioGetAiTransferLap(Id, ref Lap);
			return ret;
		}
		public int GetAiStopTriggerTransferCount(short Id, out int Count)
		{
			Count = 0;
			int ret = AioGetAiStopTriggerTransferCount(Id, ref Count);
			return ret;
		}
		public int GetAiRepeatCount(short Id, out int AiRepeatCount)
		{
			AiRepeatCount = 0;
			int ret = AioGetAiRepeatCount(Id, ref AiRepeatCount);
			return ret;
		}
		public int GetAiSamplingData(short Id, ref int AiSamplingTimes, ref int[] AiData)
		{
			int ret = AioGetAiSamplingData(Id, ref AiSamplingTimes, AiData);
			return ret;
		}
		public int GetAiSamplingDataEx(short Id, ref int AiSamplingTimes, ref float[] AiData)
		{
			int ret = AioGetAiSamplingDataEx(Id, ref AiSamplingTimes, AiData);
			return ret;
		}
		public int ResetAiStatus(short Id)
		{
			int ret = AioResetAiStatus(Id);
			return ret;
		}
		public int ResetAiMemory(short Id)
		{
			int ret = AioResetAiMemory(Id);
			return ret;
		}
		
		// �A�i���O�o�͊֐�
		public int SingleAo(short Id, short AoChannel, int AoData)
		{
			int ret = AioSingleAo(Id, AoChannel, AoData);
			return ret;
		}
		public int SingleAoEx(short Id, short AoChannel, float AoData)
		{
			int ret = AioSingleAoEx(Id, AoChannel, AoData);
			return ret;
		}
		public int MultiAo(short Id, short AoChannels, int[] AoData)
		{
			int ret = AioMultiAo(Id, AoChannels, AoData);
			return ret;
		}
		public int MultiAoEx(short Id, short AoChannels, float[] AoData)
		{
			int ret = AioMultiAoEx(Id, AoChannels, AoData);
			return ret;
		}
		public int GetAoResolution(short Id, out short AoResolution)
		{
			AoResolution = 0;
			int ret = AioGetAoResolution(Id, ref AoResolution);
			return ret;
		}
		public int SetAoChannels(short Id, short AoChannels)
		{
			int ret = AioSetAoChannels(Id, AoChannels);
			return ret;
		}
		public int GetAoChannels(short Id, out short AoChannels)
		{
			AoChannels = 0;
			int ret = AioGetAoChannels(Id, ref AoChannels);
			return ret;
		}
		public int GetAoMaxChannels(short Id, out short AoMaxChannels)
		{
			AoMaxChannels = 0;
			int ret = AioGetAoMaxChannels(Id, ref AoMaxChannels);
			return ret;
		}
		public int SetAoRange(short Id, short AoChannel, short AoRange)
		{
			int ret = AioSetAoRange(Id, AoChannel, AoRange);
			return ret;
		}
		public int SetAoRangeAll(short Id, short AoRange)
		{
			int ret = AioSetAoRangeAll(Id, AoRange);
			return ret;
		}
		public int GetAoRange(short Id, short AoChannel, out short AoRange)
		{
			AoRange = 0;
			int ret = AioGetAoRange(Id, AoChannel, ref AoRange);
			return ret;
		}
		public int SetAoTransferMode(short Id, short AoTransferMode)
		{
			int ret = AioSetAoTransferMode(Id, AoTransferMode);
			return ret;
		}
		public int GetAoTransferMode(short Id, out short AoTransferMode)
		{
			AoTransferMode = 0;
			int ret = AioGetAoTransferMode(Id, ref AoTransferMode);
			return ret;
		}
		public int SetAoDeviceBufferMode(short Id, short AoDeviceBufferMode)
		{
			int ret = AioSetAoDeviceBufferMode(Id, AoDeviceBufferMode);
			return ret;
		}
		public int GetAoDeviceBufferMode(short Id, out short AoDeviceBufferMode)
		{
			AoDeviceBufferMode = 0;
			int ret = AioGetAoDeviceBufferMode(Id, ref AoDeviceBufferMode);
			return ret;
		}
		public int SetAoMemorySize(short Id, short AoMemorySize)
		{
			int ret = AioSetAoMemorySize(Id, AoMemorySize);
			return ret;
		}
		public int GetAoMemorySize(short Id, out int AoMemorySize)
		{
			AoMemorySize = 0;
			int ret = AioGetAoMemorySize(Id, ref AoMemorySize);
			return ret;
		}
		public int SetAoTransferData(short Id, int DataNumber, IntPtr Buffer)
		{
			int ret = AioSetAoTransferData(Id, DataNumber, Buffer);
			return ret;
		}
		public int GetAoSamplingDataSize(short Id, out short DataSize)
		{
			DataSize = 0;
			int ret = AioGetAoSamplingDataSize(Id, ref DataSize);
			return ret;
		}
		public int SetAoMemoryType(short Id, short AoMemoryType)
		{
			int ret = AioSetAoMemoryType(Id, AoMemoryType);
			return ret;
		}
		public int GetAoMemoryType(short Id, out short AoMemoryType)
		{
			AoMemoryType = 0;
			int ret = AioGetAoMemoryType(Id, ref AoMemoryType);
			return ret;
		}
		public int SetAoRepeatTimes(short Id, int AoRepeatTimes)
		{
			int ret = AioSetAoRepeatTimes(Id, AoRepeatTimes);
			return ret;
		}
		public int GetAoRepeatTimes(short Id, out int AoRepeatTimes)
		{
			AoRepeatTimes = 0;
			int ret = AioGetAoRepeatTimes(Id, ref AoRepeatTimes);
			return ret;
		}
		public int SetAoClockType(short Id, short AoClockType)
		{
			int ret = AioSetAoClockType(Id, AoClockType);
			return ret;
		}
		public int GetAoClockType(short Id, out short AoClockType)
		{
			AoClockType = 0;
			int ret = AioGetAoClockType(Id, ref AoClockType);
			return ret;
		}
		public int SetAoSamplingClock(short Id, float AoSamplingClock)
		{
			int ret = AioSetAoSamplingClock(Id, AoSamplingClock);
			return ret;
		}
		public int GetAoSamplingClock(short Id, out float AoSamplingClock)
		{
			AoSamplingClock = 0;
			int ret = AioGetAoSamplingClock(Id, ref AoSamplingClock);
			return ret;
		}
		public int SetAoClockEdge(short Id, short AoClockEdge)
		{
			int ret = AioSetAoClockEdge(Id, AoClockEdge);
			return ret;
		}
		public int GetAoClockEdge(short Id, out short AoClockEdge)
		{
			AoClockEdge = 0;
			int ret = AioGetAoClockEdge(Id, ref AoClockEdge);
			return ret;
		}
		public int SetAoSamplingData(short Id, int AoSamplingTimes, int[] AoData)
		{
			int ret = AioSetAoSamplingData(Id, AoSamplingTimes, AoData);
			return ret;
		}
		public int SetAoSamplingDataEx(short Id, int AoSamplingTimes, float[] AoData)
		{
			int ret = AioSetAoSamplingDataEx(Id, AoSamplingTimes, AoData);
			return ret;
		}
		public int GetAoSamplingTimes(short Id, out int AoSamplingTimes)
		{
			AoSamplingTimes = 0;
			int ret = AioGetAoSamplingTimes(Id, ref AoSamplingTimes);
			return ret;
		}
		public int SetAoStartTrigger(short Id, short AoStartTrigger)
		{
			int ret = AioSetAoStartTrigger(Id, AoStartTrigger);
			return ret;
		}
		public int GetAoStartTrigger(short Id, out short AoStartTrigger)
		{
			AoStartTrigger = 0;
			int ret = AioGetAoStartTrigger(Id, ref AoStartTrigger);
			return ret;
		}
		public int SetAoStopTrigger(short Id, short AoStopTrigger)
		{
			int ret = AioSetAoStopTrigger(Id, AoStopTrigger);
			return ret;
		}
		public int GetAoStopTrigger(short Id, out short AoStopTrigger)
		{
			AoStopTrigger = 0;
			int ret = AioGetAoStopTrigger(Id, ref AoStopTrigger);
			return ret;
		}
		public int SetAoEvent(short Id, uint hWnd, int AoEvent)
		{
			int ret = AioSetAoEvent(Id, hWnd, AoEvent);
			return ret;
		}
		public int GetAoEvent(short Id, out uint hWnd, out int AoEvent)
		{
			hWnd = 0;
			AoEvent = 0;
			int ret = AioGetAoEvent(Id, ref hWnd, ref AoEvent);
			return ret;
		}
		unsafe public int SetAoCallBackProc(short Id, PAOCALLBACK pAoCallBack, int AoEvent, void *Param)
		{
			int ret = AioSetAoCallBackProc(Id, pAoCallBack, AoEvent, Param);
			return ret;
		}
		public int SetAoEventSamplingTimes(short Id, int AoSamplingTimes)
		{
			int ret = AioSetAoEventSamplingTimes(Id, AoSamplingTimes);
			return ret;
		}
		public int GetAoEventSamplingTimes(short Id, out int AoSamplingTimes)
		{
			AoSamplingTimes = 0;
			int ret = AioGetAoEventSamplingTimes(Id, ref AoSamplingTimes);
			return ret;
		}
		public int SetAoEventTransferTimes(short Id, int AoTransferTimes)
		{
			int ret = AioSetAoEventTransferTimes(Id, AoTransferTimes);
			return ret;
		}
		public int GetAoEventTransferTimes(short Id, out int AoTransferTimes)
		{
			AoTransferTimes = 0;
			int ret = AioGetAoEventTransferTimes(Id, ref AoTransferTimes);
			return ret;
		}
		public int StartAo(short Id)
		{
			int ret = AioStartAo(Id);
			return ret;
		}
		public int StopAo(short Id)
		{
			int ret = AioStopAo(Id);
			return ret;
		}
		public int EnableAo(short Id, short AoChannel)
		{
			int ret = AioEnableAo(Id, AoChannel);
			return ret;
		}
		public int DisableAo(short Id, short AoChannel)
		{
			int ret = AioDisableAo(Id, AoChannel);
			return ret;
		}
		public int GetAoStatus(short Id, out int AoStatus)
		{
			AoStatus = 0;
			int ret = AioGetAoStatus(Id, ref AoStatus);
			return ret;
		}
		public int GetAoSamplingCount(short Id, out int AoSamplingCount)
		{
			AoSamplingCount = 0;
			int ret = AioGetAoSamplingCount(Id, ref AoSamplingCount);
			return ret;
		}
		public int GetAoTransferCount(short Id, out int AoTransferCount)
		{
			AoTransferCount = 0;
			int ret = AioGetAoTransferCount(Id, ref AoTransferCount);
			return ret;
		}
		public int GetAoTransferLap(short Id, out int Lap)
		{
			Lap = 0;
			int ret = AioGetAoTransferLap(Id, ref Lap);
			return ret;
		}
		public int GetAoRepeatCount(short Id, out int AoRepeatCount)
		{
			AoRepeatCount = 0;
			int ret = AioGetAoRepeatCount(Id, ref AoRepeatCount);
			return ret;
		}
		public int ResetAoStatus(short Id)
		{
			int ret = AioResetAoStatus(Id);
			return ret;
		}
		public int ResetAoMemory(short Id)
		{
			int ret = AioResetAoMemory(Id);
			return ret;
		}
		
		// �f�W�^�����o�͊֐�
		public int SetDiFilter(short Id, short Bit, float Value)
		{
			int ret = AioSetDiFilter(Id, Bit, Value);
			return ret;
		}
		public int GetDiFilter(short Id, short Bit, out float Value)
		{
			Value = 0;
			int ret = AioGetDiFilter(Id, Bit, ref Value);
			return ret;
		}
		public int InputDiBit(short Id, short DiBit, out short DiData)
		{
			DiData = 0;
			int ret = AioInputDiBit(Id, DiBit, ref DiData);
			return ret;
		}
		public int OutputDoBit(short Id, short DoBit, short DoData)
		{
			int ret = AioOutputDoBit(Id, DoBit, DoData);
			return ret;
		}
		public int InputDiByte(short Id, short DiPort, out short DiData)
		{
			DiData = 0;
			int ret = AioInputDiByte(Id, DiPort, ref DiData);
			return ret;
		}
		public int OutputDoByte(short Id, short DoPort, short DoData)
		{
			int ret = AioOutputDoByte(Id, DoPort, DoData);
			return ret;
		}
		public int SetDioDirection(short Id, int Dir)
        {
            int ret = AioSetDioDirection(Id, Dir);
            return ret;
        }
        public int GetDioDirection(short Id, out int Dir)
        {
            Dir = 0;
            int ret = AioGetDioDirection(Id, ref Dir);
            return ret;
        }
        
		// �J�E���^�֐�
		public int GetCntMaxChannels(short Id, out short CntMaxChannels)
		{
			CntMaxChannels = 0;
			int ret = AioGetCntMaxChannels(Id, ref CntMaxChannels);
			return ret;
		}
		public int SetCntComparisonMode(short Id, short CntChannel, short CntMode)
		{
			int ret = AioSetCntComparisonMode(Id, CntChannel, CntMode);
			return ret;
		}
		public int GetCntComparisonMode(short Id, short CntChannel, out short CntMode)
		{
			CntMode = 0;
			int ret = AioGetCntComparisonMode(Id, CntChannel, ref CntMode);
			return ret;
		}
		public int SetCntPresetReg(short Id, short CntChannel, int PresetNumber, int[] PresetData, short Flag)
		{
			int ret = AioSetCntPresetReg(Id, CntChannel, PresetNumber, PresetData, Flag);
			return ret;
		}
		public int SetCntComparisonReg(short Id, short CntChannel, int ComparisonNumber, int[] ComparisonData, short Flag)
		{
			int ret = AioSetCntComparisonReg(Id, CntChannel, ComparisonNumber, ComparisonData, Flag);
			return ret;
		}
		public int SetCntInputSignal(short Id, short CntChannel, short CntInputSignal)
		{
			int ret = AioSetCntInputSignal(Id, CntChannel, CntInputSignal);
			return ret;
		}
		public int GetCntInputSignal(short Id, short CntChannel, out short CntInputSignal)
		{
			CntInputSignal = 0;
			int ret = AioGetCntInputSignal(Id, CntChannel, ref CntInputSignal);
			return ret;
		}
		public int SetCntEvent(short Id, short CntChannel, uint hWnd, int CntEvent)
		{
			int ret = AioSetCntEvent(Id, CntChannel, hWnd, CntEvent);
			return ret;
		}
		public int GetCntEvent(short Id, short CntChannel, out uint hWnd, out int CntEvent)
		{
			hWnd = 0;
			CntEvent = 0;
			int ret = AioGetCntEvent(Id, CntChannel, ref hWnd, ref CntEvent);
			return ret;
		}
		unsafe public int SetCntCallBackProc(short Id, short CntChannel, PCNTCALLBACK pCntCallBack, int CntEvent, void *Param)
		{
			int ret = AioSetCntCallBackProc(Id, CntChannel, pCntCallBack, CntEvent, Param);
			return ret;
		}
		public int SetCntFilter(short Id, short CntChannel, short Signal, float Value)
		{
			int ret = AioSetCntFilter(Id, CntChannel, Signal, Value);
			return ret;
		}
		public int GetCntFilter(short Id, short CntChannel, short Signal, out float Value)
		{
			Value = 0;
			int ret = AioGetCntFilter(Id, CntChannel, Signal, ref Value);
			return ret;
		}
		public int StartCnt(short Id, short CntChannel)
		{
			int ret = AioStartCnt(Id, CntChannel);
			return ret;
		}
		public int StopCnt(short Id, short CntChannel)
		{
			int ret = AioStopCnt(Id, CntChannel);
			return ret;
		}
		public int PresetCnt(short Id, short CntChannel, int PresetData)
		{
			int ret = AioPresetCnt(Id, CntChannel, PresetData);
			return ret;
		}
		public int GetCntStatus(short Id, short CntChannel, out int CntStatus)
		{
			CntStatus = 0;
			int ret = AioGetCntStatus(Id, CntChannel, ref CntStatus);
			return ret;
		}
		public int GetCntCount(short Id, short CntChannel, out int Count)
		{
			Count = 0;
			int ret = AioGetCntCount(Id, CntChannel, ref Count);
			return ret;
		}
		public int ResetCntStatus(short Id, short CntChannel, int CntStatus)
		{
			int ret = AioResetCntStatus(Id, CntChannel, CntStatus);
			return ret;
		}
		
		// �^�C�}�֐�
		public int SetTmEvent(short Id, short TimerId, uint hWnd, int TmEvent)
		{
			int ret = AioSetTmEvent(Id, TimerId, hWnd, TmEvent);
			return ret;
		}
		public int GetTmEvent(short Id, short TimerId, out uint hWnd, out int TmEvent)
		{
			hWnd = 0;
			TmEvent = 0;
			int ret = AioGetTmEvent(Id, TimerId, ref hWnd, ref TmEvent);
			return ret;
		}
		unsafe public int SetTmCallBackProc(short Id, short TimerId, PTMCALLBACK pTmCallBack, int TmEvent, void *Param)
		{
			int ret = AioSetTmCallBackProc(Id, TimerId, pTmCallBack, TmEvent, Param);
			return ret;
		}
		public int StartTmTimer(short Id, short TimerId, float Interval)
		{
			int ret = AioStartTmTimer(Id, TimerId, Interval);
			return ret;
		}
		public int StopTmTimer(short Id, short TimerId)
		{
			int ret = AioStopTmTimer(Id, TimerId);
			return ret;
		}
		public int StartTmCount(short Id, short TimerId)
		{
			int ret = AioStartTmCount(Id, TimerId);
			return ret;
		}
		public int StopTmCount(short Id, short TimerId)
		{
			int ret = AioStopTmCount(Id, TimerId);
			return ret;
		}
		public int LapTmCount(short Id, short TimerId, out int Lap)
		{
			Lap = 0;
			int ret = AioLapTmCount(Id, TimerId, ref Lap);
			return ret;
		}
		public int ResetTmCount(short Id, short TimerId)
		{
			int ret = AioResetTmCount(Id, TimerId);
			return ret;
		}
		public int TmWait(short Id, short TimerId, int Wait)
		{
			int ret = AioTmWait(Id, TimerId, Wait);
			return ret;
		}
		
		// �C�x���g�R���g���[��
		public int SetEcuSignal(short Id, short Destination, short Source)
		{
			int ret = AioSetEcuSignal(Id, Destination, Source);
			return ret;
		}
		public int GetEcuSignal(short Id, short Destination, out short Source)
		{
			Source = 0;
			int ret = AioGetEcuSignal(Id, Destination, ref Source);
			return ret;
		}
		
		
		// Setting function (set)
		public int GetCntmMaxChannels(short Id, out short CntmMaxChannels)
		{
			CntmMaxChannels = 0;
			int ret = AioGetCntmMaxChannels(Id, ref CntmMaxChannels);
			return ret;
		}
		public int SetCntmZMode(short Id, short ChNo, short Mode)
		{
			int ret = AioSetCntmZMode(Id, ChNo, Mode);
			return ret;
		}
		public int SetCntmZLogic(short Id, short ChNo, short ZLogic)
		{
			int ret = AioSetCntmZLogic(Id, ChNo, ZLogic);
			return ret;
		}
		public int SelectCntmChannelSignal(short Id, short ChNo, short SigType)
		{
			int ret = AioSelectCntmChannelSignal(Id, ChNo, SigType);
			return ret;
		}
		public int SetCntmCountDirection(short Id, short ChNo, short Dir)
		{
			int ret = AioSetCntmCountDirection(Id, ChNo, Dir);
			return ret;
		}
		public int SetCntmOperationMode(short Id, short ChNo, short Phase, short Mul, short SyncClr)
		{
			int ret = AioSetCntmOperationMode(Id, ChNo, Phase, Mul, SyncClr);
			return ret;
		}
		public int SetCntmDigitalFilter(short Id, short ChNo, short FilterValue)
		{
			int ret = AioSetCntmDigitalFilter(Id, ChNo, FilterValue);
			return ret;
		}
		public int SetCntmPulseWidth(short Id, short ChNo, short PlsWidth)
		{
			int ret = AioSetCntmPulseWidth(Id, ChNo, PlsWidth);
			return ret;
		}
		public int SetCntmDIType(short Id, short ChNo, short InputType)
		{
			int ret = AioSetCntmDIType(Id, ChNo, InputType);
			return ret;
		}
		public int SetCntmOutputHardwareEvent(short Id, short ChNo, short OutputLogic, uint EventType, short PulseWidth)
		{
			int ret = AioSetCntmOutputHardwareEvent(Id, ChNo, OutputLogic, EventType, PulseWidth);
			return ret;
		}
		public int SetCntmInputHardwareEvent(short Id, short ChNo, uint EventType, short RF0, short RF1, short Reserved)
		{
			int ret = AioSetCntmInputHardwareEvent(Id, ChNo, EventType, RF0, RF1, Reserved);
			return ret;
		}
		public int SetCntmCountMatchHardwareEvent(short Id, short ChNo, short RegisterNo, uint EventType, short Reserved)
		{
			int ret = AioSetCntmCountMatchHardwareEvent(Id, ChNo, RegisterNo, EventType, Reserved);
			return ret;
		}
		public int SetCntmPresetRegister(short Id, short ChNo, uint PresetData, short Reserved)
		{
			int ret = AioSetCntmPresetRegister(Id, ChNo, PresetData, Reserved);
			return ret;
		}
		public int SetCntmTestPulse(short Id, short CntmInternal, short CntmOut, short CntmReserved)
		{
			int ret = AioSetCntmTestPulse(Id, CntmInternal, CntmOut, CntmReserved);
			return ret;
		}
		
		// Setting function (get)
		public int GetCntmZMode(short Id, short ChNo, out short Mode)
		{
			Mode = 1;
			int ret = AioGetCntmZMode(Id, ChNo, ref Mode);
			return ret;
		}
		public int GetCntmZLogic(short Id, short ChNo,out short ZLogic)
		{
			ZLogic = 1;
			int ret = AioGetCntmZLogic(Id, ChNo, ref ZLogic);
			return ret;
		}
		public int GetCntmChannelSignal(short Id, short CntmChNo, out short CntmSigType)
		{
			CntmSigType = 1;
			int ret = AioGetCntmChannelSignal(Id, CntmChNo, ref CntmSigType);
			return ret;
		}
		public int GetCntmCountDirection(short Id, short ChNo, out short Dir)
		{
			Dir = 1;
			int ret = AioGetCntmCountDirection(Id, ChNo, ref Dir);
			return ret;
		}
		public int GetCntmOperationMode(short Id, short ChNo, out short Phase, out short Mul, out short SyncClr)
		{
			Phase = 1;
			Mul = 0;
			SyncClr = 0;
			int ret = AioGetCntmOperationMode(Id, ChNo, ref Phase, ref Mul, ref SyncClr);
			return ret;
		}
		public int GetCntmDigitalFilter(short Id, short ChNo, out short FilterValue)
		{
			FilterValue = 0;
			int ret = AioGetCntmDigitalFilter(Id, ChNo, ref FilterValue);
			return ret;
		}
		public int GetCntmPulseWidth(short Id, short ChNo, out short PlsWidth)
		{
			PlsWidth = 0;
			int ret = AioGetCntmPulseWidth(Id, ChNo, ref PlsWidth);
			return ret;
		}
		
		// Counter function
		public int CntmStartCount(short Id, short[] ChNo, short ChNum)
		{
			int ret = AioCntmStartCount(Id, ChNo, ChNum);
			return ret;
		}
		public int CntmStopCount(short Id, short[] ChNo, short ChNum)
		{
			int ret = AioCntmStopCount(Id, ChNo, ChNum);
			return ret;
		}
		public int CntmPreset(short Id, short[] ChNo, short ChNum, uint[] PresetData)
		{
			int ret = AioCntmPreset(Id, ChNo, ChNum, PresetData);
			return ret;
		}
		public int CntmZeroClearCount(short Id, short[] ChNo, short ChNum)
		{
			int ret = AioCntmZeroClearCount(Id, ChNo, ChNum);
			return ret;
		}
		public int CntmReadCount(short Id, short[] ChNo, short ChNum, uint[] CntDat)
		{
			int ret = AioCntmReadCount(Id, ChNo, ChNum, CntDat);
			return ret;
		}
		public int CntmReadStatus(short Id, short ChNo, out short Sts)
		{
			Sts = 0;
			int ret = AioCntmReadStatus(Id, ChNo, ref Sts);
			return ret;
		}
		public int CntmReadStatusEx(short Id, short ChNo, out uint Sts)
		{
			Sts = 0;
			int ret = AioCntmReadStatusEx(Id, ChNo, ref Sts);
			return ret;
		}
		
		// Notify function
		public int CntmNotifyCountUp(short Id, short ChNo, short RegNo, uint Count, int hWnd)
		{
			int ret = AioCntmNotifyCountUp(Id, ChNo, RegNo, Count, hWnd);
			return ret;
		}
		public int CntmStopNotifyCountUp(short Id, short ChNo, short RegNo)
		{
			int ret = AioCntmStopNotifyCountUp(Id, ChNo, RegNo);
			return ret;
		}		
		unsafe public int CntmCountUpCallbackProc(short Id , PAIOCNTMCOUNTUPCALLBACK pAioCntmCountUpCallBack , void *Param)
		{
			int ret = AioCntmCountUpCallbackProc(Id, pAioCntmCountUpCallBack, Param);
			return ret;
		}
		public int CntmNotifyCounterError(short Id, int hWnd)
		{
			int ret = AioCntmNotifyCounterError(Id, hWnd);
			return ret;
		}
		public int CntmStopNotifyCounterError(short Id)
		{
			int ret = AioCntmStopNotifyCounterError(Id);
			return ret;
		}
		unsafe public int CntmCounterErrorCallbackProc(short Id, PAIOCNTMCOUNTERERRORCALLBACK pAioCntmCounterErrorCallBack, void *Param)
		{
			int ret = AioCntmCounterErrorCallbackProc(Id, pAioCntmCounterErrorCallBack, Param);
			return ret;
		}
		public int CntmNotifyCarryBorrow(short Id, int hWnd)
		{
			int ret = AioCntmNotifyCarryBorrow(Id, hWnd);
			return ret;
		}
		public int CntmStopNotifyCarryBorrow(short Id)
		{
			int ret = AioCntmStopNotifyCarryBorrow(Id);
			return ret;
		}
		unsafe public int CntmCarryBorrowCallbackProc(short Id, PAIOCNTMCARRYBORROWCALLBACK pAioCntmCarryBorrowCallBack, void *Param)
		{
			int ret = AioCntmCarryBorrowCallbackProc(Id, pAioCntmCarryBorrowCallBack, Param);
			return ret;
		}
		public int CntmNotifyTimer(short Id, uint TimeValue, int hWnd)
		{
			int ret = AioCntmNotifyTimer(Id, TimeValue, hWnd);
			return ret;
		}
		public int CntmStopNotifyTimer(short Id)
		{
			int ret = AioCntmStopNotifyTimer(Id);
			return ret;
		}
		unsafe public int CntmTimerCallbackProc(short Id, PAIOCNTMTMCALLBACK pAioCntmTmCallBack , void *Param)
		{
			int ret = AioCntmTimerCallbackProc(Id, pAioCntmTmCallBack, Param);
			return ret;
		}
		
		// General purpose input function
		public int CntmInputDIByte(short Id, short Reserved, out byte bData)
		{
			bData = 0;
			int ret = AioCntmInputDIByte(Id, Reserved, ref bData);
			return ret;
		}
		public int CntmOutputDOBit(short Id, short AiomChNo, short Reserved, byte OutData)
		{
			int ret = AioCntmOutputDOBit(Id, AiomChNo, Reserved, OutData);
			return ret;
		}
	}
}
