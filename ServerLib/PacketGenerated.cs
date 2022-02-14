﻿
/**************************************

	이 파일은 자동 생성되는 파일입니다.
		절대 직접 수정하지마세요.

**************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib.Packet
{
	
    public class Ping_RQ : PacketBase
    {
        public override ushort PacketId => Id;

        public override ushort PacketSize => (ushort)(sizeof(long));
        public const ushort Id = 0;

		
		public DateTime time;
	
    }
	
    public class Ping_RS : PacketBase
    {
        public override ushort PacketId => Id;

        public override ushort PacketSize => (ushort)(sizeof(long));
        public const ushort Id = 1;

		
		public DateTime time;
	
    }
	
    public class ChatMsg_RQ : PacketBase
    {
        public override ushort PacketId => Id;

        public override ushort PacketSize => (ushort)(sizeof(int) + Encoding.UTF8.GetByteCount(msgText) + sizeof(long));
        public const ushort Id = 2;

		
		public string msgText;
	
		public DateTime time;
	
    }
	
    public class ChatMsg_RS : PacketBase
    {
        public override ushort PacketId => Id;

        public override ushort PacketSize => (ushort)(sizeof(int) + Encoding.UTF8.GetByteCount(msgText) + sizeof(long));
        public const ushort Id = 3;

		
		public string msgText;
	
		public DateTime time;
	
    }
	
    public class ListTest_RQ : PacketBase
    {
        public override ushort PacketId => Id;

        public override ushort PacketSize => (ushort)(sizeof(int) + (sentences.Count * (sizeof(int) + Encoding.UTF8.GetByteCount({0}))) + sizeof(long) + sizeof(int) + Encoding.UTF8.GetByteCount(nickname));
        public const ushort Id = 4;

		
		public List<string> sentences;
	
		public DateTime time;
	
		public string nickname;
	
    }
	
    public class ListTest_RS : PacketBase
    {
        public override ushort PacketId => Id;

        public override ushort PacketSize => (ushort)(sizeof(int) + (numOfCharacters.Count * (sizeof(int))) + sizeof(long) + sizeof(int) + Encoding.UTF8.GetByteCount(nickname));
        public const ushort Id = 5;

		
		public List<int> numOfCharacters;
	
		public DateTime time;
	
		public string nickname;
	
    }
	
}