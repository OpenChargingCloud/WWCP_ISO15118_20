/*
 * Copyright (c) 2021-2022 GraphDefined GmbH
 * This file is part of WWCP ISO 15118-20 <https://github.com/OpenChargingCloud/WWCP_ISO15118_20>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#region Usings

using cloud.charging.open.protocols.ISO15118_20.CommonTypes;

#endregion

namespace cloud.charging.open.protocols.ISO15118_20.AC
{

    public class BPT_Scheduled_AC_CLReqControlMode : Scheduled_AC_CLReqControlMode
    {

        public RationalNumber?  EVMaximumDischargePower       { get; }
        public RationalNumber?  EVMaximumDischargePower_L2    { get; }
        public RationalNumber?  EVMaximumDischargePower_L3    { get; }

        public RationalNumber?  EVMinimumDischargePower       { get; }
        public RationalNumber?  EVMinimumDischargePower_L2    { get; }
        public RationalNumber?  EVMinimumDischargePower_L3    { get; }


        #region Documentation

        // <xs:complexType name="BPT_Scheduled_AC_CLReqControlModeType">
        //     <xs:complexContent>
        //         <xs:extension base="Scheduled_AC_CLReqControlModeType">
        //             <xs:sequence>
        //                 <xs:element name="EVMaximumDischargePower"    type="v2gci_ct:RationalNumberType" minOccurs="0"/>
        //                 <xs:element name="EVMaximumDischargePower_L2" type="v2gci_ct:RationalNumberType" minOccurs="0"/>
        //                 <xs:element name="EVMaximumDischargePower_L3" type="v2gci_ct:RationalNumberType" minOccurs="0"/>
        //                 <xs:element name="EVMinimumDischargePower"    type="v2gci_ct:RationalNumberType" minOccurs="0"/>
        //                 <xs:element name="EVMinimumDischargePower_L2" type="v2gci_ct:RationalNumberType" minOccurs="0"/>
        //                 <xs:element name="EVMinimumDischargePower_L3" type="v2gci_ct:RationalNumberType" minOccurs="0"/>
        //             </xs:sequence>
        //         </xs:extension>
        //     </xs:complexContent>
        // </xs:complexType>

        #endregion

    }

}
