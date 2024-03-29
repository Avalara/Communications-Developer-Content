# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from avalara.comms.rest.v2.configuration import Configuration


class SummarizedTax(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'max': 'float',
        'min': 'float',
        'tchg': 'float',
        'calc': 'int',
        'cat': 'str',
        'cid': 'int',
        'name': 'str',
        'exm': 'float',
        'lns': 'int',
        'pcd': 'int',
        'taxpcd': 'int',
        'rate': 'float',
        'sur': 'bool',
        'tax': 'float',
        'lvl': 'int',
        'tid': 'int',
        'usexm': 'bool',
        'notax': 'bool',
        'trans': 'int',
        'svc': 'int',
        'chg': 'float'
    }

    attribute_map = {
        'max': 'max',
        'min': 'min',
        'tchg': 'tchg',
        'calc': 'calc',
        'cat': 'cat',
        'cid': 'cid',
        'name': 'name',
        'exm': 'exm',
        'lns': 'lns',
        'pcd': 'pcd',
        'taxpcd': 'taxpcd',
        'rate': 'rate',
        'sur': 'sur',
        'tax': 'tax',
        'lvl': 'lvl',
        'tid': 'tid',
        'usexm': 'usexm',
        'notax': 'notax',
        'trans': 'trans',
        'svc': 'svc',
        'chg': 'chg'
    }

    def __init__(self, max=None, min=None, tchg=None, calc=None, cat=None, cid=None, name=None, exm=None, lns=None, pcd=None, taxpcd=None, rate=None, sur=None, tax=None, lvl=None, tid=None, usexm=None, notax=None, trans=None, svc=None, chg=None, local_vars_configuration=None):  # noqa: E501
        """SummarizedTax - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._max = None
        self._min = None
        self._tchg = None
        self._calc = None
        self._cat = None
        self._cid = None
        self._name = None
        self._exm = None
        self._lns = None
        self._pcd = None
        self._taxpcd = None
        self._rate = None
        self._sur = None
        self._tax = None
        self._lvl = None
        self._tid = None
        self._usexm = None
        self._notax = None
        self._trans = None
        self._svc = None
        self._chg = None
        self.discriminator = None

        self.max = max
        self.min = min
        self.tchg = tchg
        self.calc = calc
        self.cat = cat
        self.cid = cid
        self.name = name
        self.exm = exm
        self.lns = lns
        self.pcd = pcd
        self.taxpcd = taxpcd
        self.rate = rate
        self.sur = sur
        self.tax = tax
        self.lvl = lvl
        self.tid = tid
        self.usexm = usexm
        self.notax = notax
        self.trans = trans
        self.svc = svc
        self.chg = chg

    @property
    def max(self):
        """Gets the max of this SummarizedTax.  # noqa: E501

        Maximum base for tax bracket.  # noqa: E501

        :return: The max of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._max

    @max.setter
    def max(self, max):
        """Sets the max of this SummarizedTax.

        Maximum base for tax bracket.  # noqa: E501

        :param max: The max of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._max = max

    @property
    def min(self):
        """Gets the min of this SummarizedTax.  # noqa: E501

        Minimum base for tax bracket.  # noqa: E501

        :return: The min of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._min

    @min.setter
    def min(self, min):
        """Sets the min of this SummarizedTax.

        Minimum base for tax bracket.  # noqa: E501

        :param min: The min of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._min = min

    @property
    def tchg(self):
        """Gets the tchg of this SummarizedTax.  # noqa: E501

        Total charge amount.  # noqa: E501

        :return: The tchg of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._tchg

    @tchg.setter
    def tchg(self, tchg):
        """Sets the tchg of this SummarizedTax.

        Total charge amount.  # noqa: E501

        :param tchg: The tchg of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._tchg = tchg

    @property
    def calc(self):
        """Gets the calc of this SummarizedTax.  # noqa: E501

        Calculation type.  # noqa: E501

        :return: The calc of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._calc

    @calc.setter
    def calc(self, calc):
        """Sets the calc of this SummarizedTax.

        Calculation type.  # noqa: E501

        :param calc: The calc of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._calc = calc

    @property
    def cat(self):
        """Gets the cat of this SummarizedTax.  # noqa: E501

        Tax category name.  # noqa: E501

        :return: The cat of this SummarizedTax.  # noqa: E501
        :rtype: str
        """
        return self._cat

    @cat.setter
    def cat(self, cat):
        """Sets the cat of this SummarizedTax.

        Tax category name.  # noqa: E501

        :param cat: The cat of this SummarizedTax.  # noqa: E501
        :type: str
        """

        self._cat = cat

    @property
    def cid(self):
        """Gets the cid of this SummarizedTax.  # noqa: E501

        Tax category ID.  # noqa: E501

        :return: The cid of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._cid

    @cid.setter
    def cid(self, cid):
        """Sets the cid of this SummarizedTax.

        Tax category ID.  # noqa: E501

        :param cid: The cid of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._cid = cid

    @property
    def name(self):
        """Gets the name of this SummarizedTax.  # noqa: E501

        Tax name.  # noqa: E501

        :return: The name of this SummarizedTax.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this SummarizedTax.

        Tax name.  # noqa: E501

        :param name: The name of this SummarizedTax.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def exm(self):
        """Gets the exm of this SummarizedTax.  # noqa: E501

        Exempt sale amount.  # noqa: E501

        :return: The exm of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._exm

    @exm.setter
    def exm(self, exm):
        """Sets the exm of this SummarizedTax.

        Exempt sale amount.  # noqa: E501

        :param exm: The exm of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._exm = exm

    @property
    def lns(self):
        """Gets the lns of this SummarizedTax.  # noqa: E501

        Lines.  # noqa: E501

        :return: The lns of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._lns

    @lns.setter
    def lns(self, lns):
        """Sets the lns of this SummarizedTax.

        Lines.  # noqa: E501

        :param lns: The lns of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._lns = lns

    @property
    def pcd(self):
        """Gets the pcd of this SummarizedTax.  # noqa: E501

        PCode for reporting jurisdiction.  # noqa: E501

        :return: The pcd of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._pcd

    @pcd.setter
    def pcd(self, pcd):
        """Sets the pcd of this SummarizedTax.

        PCode for reporting jurisdiction.  # noqa: E501

        :param pcd: The pcd of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._pcd = pcd

    @property
    def taxpcd(self):
        """Gets the taxpcd of this SummarizedTax.  # noqa: E501

        PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true  # noqa: E501

        :return: The taxpcd of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._taxpcd

    @taxpcd.setter
    def taxpcd(self, taxpcd):
        """Sets the taxpcd of this SummarizedTax.

        PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true  # noqa: E501

        :param taxpcd: The taxpcd of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._taxpcd = taxpcd

    @property
    def rate(self):
        """Gets the rate of this SummarizedTax.  # noqa: E501

        Tax rate.  # noqa: E501

        :return: The rate of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._rate

    @rate.setter
    def rate(self, rate):
        """Sets the rate of this SummarizedTax.

        Tax rate.  # noqa: E501

        :param rate: The rate of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._rate = rate

    @property
    def sur(self):
        """Gets the sur of this SummarizedTax.  # noqa: E501

        Indicates if this tax is a surcharge.  # noqa: E501

        :return: The sur of this SummarizedTax.  # noqa: E501
        :rtype: bool
        """
        return self._sur

    @sur.setter
    def sur(self, sur):
        """Sets the sur of this SummarizedTax.

        Indicates if this tax is a surcharge.  # noqa: E501

        :param sur: The sur of this SummarizedTax.  # noqa: E501
        :type: bool
        """

        self._sur = sur

    @property
    def tax(self):
        """Gets the tax of this SummarizedTax.  # noqa: E501

        Tax amount.  # noqa: E501

        :return: The tax of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._tax

    @tax.setter
    def tax(self, tax):
        """Sets the tax of this SummarizedTax.

        Tax amount.  # noqa: E501

        :param tax: The tax of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._tax = tax

    @property
    def lvl(self):
        """Gets the lvl of this SummarizedTax.  # noqa: E501

        Tax level ID.  # noqa: E501

        :return: The lvl of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._lvl

    @lvl.setter
    def lvl(self, lvl):
        """Sets the lvl of this SummarizedTax.

        Tax level ID.  # noqa: E501

        :param lvl: The lvl of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._lvl = lvl

    @property
    def tid(self):
        """Gets the tid of this SummarizedTax.  # noqa: E501

        Tax type ID.  # noqa: E501

        :return: The tid of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._tid

    @tid.setter
    def tid(self, tid):
        """Sets the tid of this SummarizedTax.

        Tax type ID.  # noqa: E501

        :param tid: The tid of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._tid = tid

    @property
    def usexm(self):
        """Gets the usexm of this SummarizedTax.  # noqa: E501

        Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true  # noqa: E501

        :return: The usexm of this SummarizedTax.  # noqa: E501
        :rtype: bool
        """
        return self._usexm

    @usexm.setter
    def usexm(self, usexm):
        """Sets the usexm of this SummarizedTax.

        Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true  # noqa: E501

        :param usexm: The usexm of this SummarizedTax.  # noqa: E501
        :type: bool
        """

        self._usexm = usexm

    @property
    def notax(self):
        """Gets the notax of this SummarizedTax.  # noqa: E501

        Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true  # noqa: E501

        :return: The notax of this SummarizedTax.  # noqa: E501
        :rtype: bool
        """
        return self._notax

    @notax.setter
    def notax(self, notax):
        """Sets the notax of this SummarizedTax.

        Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true  # noqa: E501

        :param notax: The notax of this SummarizedTax.  # noqa: E501
        :type: bool
        """

        self._notax = notax

    @property
    def trans(self):
        """Gets the trans of this SummarizedTax.  # noqa: E501

        Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true  # noqa: E501

        :return: The trans of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._trans

    @trans.setter
    def trans(self, trans):
        """Sets the trans of this SummarizedTax.

        Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true  # noqa: E501

        :param trans: The trans of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._trans = trans

    @property
    def svc(self):
        """Gets the svc of this SummarizedTax.  # noqa: E501

        Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true  # noqa: E501

        :return: The svc of this SummarizedTax.  # noqa: E501
        :rtype: int
        """
        return self._svc

    @svc.setter
    def svc(self, svc):
        """Sets the svc of this SummarizedTax.

        Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true  # noqa: E501

        :param svc: The svc of this SummarizedTax.  # noqa: E501
        :type: int
        """

        self._svc = svc

    @property
    def chg(self):
        """Gets the chg of this SummarizedTax.  # noqa: E501

        Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true  # noqa: E501

        :return: The chg of this SummarizedTax.  # noqa: E501
        :rtype: float
        """
        return self._chg

    @chg.setter
    def chg(self, chg):
        """Sets the chg of this SummarizedTax.

        Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true  # noqa: E501

        :param chg: The chg of this SummarizedTax.  # noqa: E501
        :type: float
        """

        self._chg = chg

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, SummarizedTax):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, SummarizedTax):
            return True

        return self.to_dict() != other.to_dict()
