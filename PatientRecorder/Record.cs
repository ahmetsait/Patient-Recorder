using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace PatientRecorder
{
	public enum DentColor
	{
		None,
		A1,
		A2,
		A3,
		A35,
		A4,
		B1,
		B2,
		B3,
		B4,
		C1,
		C2,
		C3,
		C4,
		D2,
		D3,
		D4
	}

	[ProtoContract]
	public struct CheckPoint
	{
		[ProtoMember(1)]
		public DateTime date;
		[ProtoMember(2)]
		public int payment;
		[ProtoMember(3)]
		public int payed;
		[ProtoMember(4)]
		public int sumPayed;

		public CheckPoint(ref DateTime date, int payment, int payed, int sumPayed)
		{
			this.date = date;
			this.payment = payment;
			this.payed = payed;
			this.sumPayed = sumPayed;
		}
	}

	[ProtoContract]
	public class Record
	{
		private const string cryptoKey = "dsf \t$½[{]ikcöç.küğı@jgr*pdfvcö~¨~;IOIYUT%/&";

		[ProtoMember(1)]
		public string nameEncrypted
		{
			get
			{
				return StringCipher.Encrypt(name, cryptoKey);
			}
			set
			{
				name = StringCipher.Decrypt(value, cryptoKey);
			}
		}
		public string name;
		[ProtoMember(2)]
		public string surnameEncrypted
		{
			get
			{
				return StringCipher.Encrypt(surname, cryptoKey);
			}
			set
			{
				surname = StringCipher.Decrypt(value, cryptoKey);
			}
		}
		public string surname;
		[ProtoMember(3)]
		public string phoneEncrypted
		{
			get
			{
				return StringCipher.Encrypt(phone, cryptoKey);
			}
			set
			{
				phone = StringCipher.Decrypt(value, cryptoKey);
			}
		}
		public string phone;
		[ProtoMember(4)]
		public DateTime dateCreation;
		[ProtoMember(5)]
		public DateTime dateModification;
		[ProtoMember(6)]
		public List<string> jobsEncrypted
		{
			get
			{
				if (jobs == null)
					return null;
				List<string> jobsE = new List<string>(jobs.Count);
				for (int i = 0; i < jobs.Count; i++)
					jobsE.Add(StringCipher.Encrypt(jobs[i], cryptoKey));
				return jobsE;
			}
			set
			{
				if (value == null)
				{
					jobs = null;
					return;
				}
				List<string> jobsD = new List<string>(value.Count);
				for (int i = 0; i < value.Count; i++)
					jobsD.Add(StringCipher.Decrypt(value[i], cryptoKey));
				jobs = jobsD;
			}
		}
		public List<string> jobs;
		[ProtoMember(7)]
		public int payment;
		[ProtoMember(8)]
		public int payed;
		[ProtoMember(9)]
		public string descriptionEncrypted
		{
			get
			{
				return StringCipher.Encrypt(description, cryptoKey);
			}
			set
			{
				description = StringCipher.Decrypt(value, cryptoKey);
			}
		}
		public string description;
		[ProtoMember(10)]
		public bool closed;
		[ProtoMember(11)]
		public DentColor color;
		[ProtoMember(12)]
		public List<CheckPoint> checkPoints;
	}
}
