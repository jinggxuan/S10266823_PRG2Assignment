﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg2_final_assgn
{
    class BoardingGate
    {
        public string GateName
        {
            get { return gateName; }
            set { gateName = value; }
        }

        public bool SupportsCFFT
        {
            get { return supportsCFFT; }
            set { supportsCFFT = value; }
        }

        public bool SupportsDDJB
        {
            get { return supportsDDJB; }
            set { supportsDDJB = value; }
        }

        public bool SupportsLWTT
        {
            get { return supportsLWTT; }
            set { supportsLWTT = value; }
        }

        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        public BoardingGate(string gateName, bool supportsCFFT, bool supportsDDJB, bool supportsLWTT, Flight flight)
        {
            GateName = gateName;
            SupportsCFFT = supportsCFFT;
            SupportsDDJB = supportsDDJB;
            SupportsLWTT = supportsLWTT;
            Flight = flight;
        }

        public double CalculateFees()
        {
            double baseFee = 300;
            double additionalFee = 0;

            if (SupportsCFFT == true)
            {
                additionalFee += 150;
            }
            if (SupportsDDJB == true)
            {
                additionalFee += 300;
            }
            if (SupportsLWTT == true)
            {
                additionalFee += 50;
            }

            return baseFee + additionalFee;
        }

        public override string ToString()
        {
            return $"Gate Name: {GateName} \t Supports CFFT: {SupportsCFFT} \t Supports DDJB: {SupportsDDJB} \t Supports LWTT: {SupportsLWTT}";
        }
    }
}
