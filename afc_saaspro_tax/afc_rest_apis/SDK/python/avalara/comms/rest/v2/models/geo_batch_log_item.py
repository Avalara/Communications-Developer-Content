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


class GeoBatchLogItem(object):
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
        'date': 'datetime',
        'status': 'str',
        'message': 'str'
    }

    attribute_map = {
        'date': 'Date',
        'status': 'Status',
        'message': 'Message'
    }

    def __init__(self, date=None, status=None, message=None, local_vars_configuration=None):  # noqa: E501
        """GeoBatchLogItem - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._date = None
        self._status = None
        self._message = None
        self.discriminator = None

        if date is not None:
            self.date = date
        self.status = status
        self.message = message

    @property
    def date(self):
        """Gets the date of this GeoBatchLogItem.  # noqa: E501

        DateTime of Log.  # noqa: E501

        :return: The date of this GeoBatchLogItem.  # noqa: E501
        :rtype: datetime
        """
        return self._date

    @date.setter
    def date(self, date):
        """Sets the date of this GeoBatchLogItem.

        DateTime of Log.  # noqa: E501

        :param date: The date of this GeoBatchLogItem.  # noqa: E501
        :type: datetime
        """

        self._date = date

    @property
    def status(self):
        """Gets the status of this GeoBatchLogItem.  # noqa: E501

        Level of Status.  # noqa: E501

        :return: The status of this GeoBatchLogItem.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this GeoBatchLogItem.

        Level of Status.  # noqa: E501

        :param status: The status of this GeoBatchLogItem.  # noqa: E501
        :type: str
        """

        self._status = status

    @property
    def message(self):
        """Gets the message of this GeoBatchLogItem.  # noqa: E501

        Output File Name.  # noqa: E501

        :return: The message of this GeoBatchLogItem.  # noqa: E501
        :rtype: str
        """
        return self._message

    @message.setter
    def message(self, message):
        """Sets the message of this GeoBatchLogItem.

        Output File Name.  # noqa: E501

        :param message: The message of this GeoBatchLogItem.  # noqa: E501
        :type: str
        """

        self._message = message

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
        if not isinstance(other, GeoBatchLogItem):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, GeoBatchLogItem):
            return True

        return self.to_dict() != other.to_dict()
